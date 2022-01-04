using System;
using AntDesign;
using System.Linq;
using UfoBlog.Domain.Dto.Article;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components.Forms;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace UfoBlog.Pages.BackStage.Article
{
    public partial class Create
    {
        private IJSObjectReference module;
        private const string baseUrl = "wwwroot/Upload/image/";
        private readonly string[] imageContentType = { "image/png", "image/jpg", "image/jpeg" };

        #region 生命周期方法

        /// <summary>
        /// 生命周期事件-渲染前
        /// </summary>
        /// <returns></returns>
        protected override async Task OnInitializedAsync()
        {
            using var context = _dbFactory.CreateDbContext();
            types = await context.Category.Where(x => !x.IsDelete).ToListAsync();
            options = context.Tag.Where(x => !x.IsDelete).Select(x => new TagDto {Id= x.Id, Checked=false, Name = x.Name, Number = x.Number, CreateTime = x.CreateTime}).ToList();
        }

        /// <summary>
        /// 生命周期事件-渲染后
        /// </summary>
        /// <param name="firstRender"></param>
        /// <returns></returns>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                module = await _js.InvokeAsync<IJSObjectReference>("import",
        "./js/Create.razor.js");

                //编辑器初始化
                await module.InvokeVoidAsync("Initialize");
            }
        }

        #endregion

        /// <summary>
        /// 文章发布
        /// </summary>
        /// <returns></returns>
        private async Task<NotificationRef> CreateArticle()
        {
            var text = await GetMarkdownValues();
            if (string.IsNullOrWhiteSpace(text))
                return await _notice.Error(new NotificationConfig { Message = "错误提示", Description = "文章内容不能为空！" });

            if (typeValue <= 0)
                return await _notice.Error(new NotificationConfig { Message = "错误提示", Description = "文章分类不能为空！" });

            loading = true;
            string tagList = ""; //标签列表
            using var context = _dbFactory.CreateDbContext();

            var updateTags = _mapper.Map<IEnumerable<Domain.Model.Article.Tag>>(options.Where(x => x.Checked));
            if (updateTags.Any())
            {
                tagList = string.Join(",", updateTags.Select(x => x.Name));
                context.Tag.UpdateRange(updateTags);
            }
                
            List<Domain.Model.Article.Tag> tagAddList = new List<Domain.Model.Article.Tag>();
            if (tags != null && tags.Count > 0)
            {
                tagList = $"{(string.IsNullOrWhiteSpace(tagList) ? null : tagList + ',')}{string.Join(",", tags)}";
                tagAddList = tags.Select(x => new Domain.Model.Article.Tag { Name = x, Number=1 }).ToList();
                await context.Tag.AddRangeAsync(tagAddList);
            }

            var host = conf.GetValue(typeof(String), "URLS");
            var filterHtml = await GetMarkdownValuesToFilterHtml();

            var article = new Domain.Model.Article.Article
            {
                Title = titleValue,
                Content = text,
                Description = filterHtml,
                Image = string.IsNullOrWhiteSpace(imageUrl)? url : host + imageUrl.Substring(7),
                LikeIt = 0,
                Comments = 0,
                Tag = tagList,
                ViewNum = 0,
                Type = typeValue,
            };
            await context.Article.AddAsync(article);

            try
            {
                await context.SaveChangesAsync();

                var category = await context.Category.FirstOrDefaultAsync(x => !x.IsDelete && x.Id == typeValue);
                if (category != null)
                {
                    category.Number += 1;
                    context.Category.Update(category);
                }

                await context.TagMap.AddRangeAsync(tagAddList.Select(x => new Domain.Model.Article.TagMap { ArticleId = article.Id, TagId = x.Id }));
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return await _notice.Error(new NotificationConfig { Message = "错误提示", Description = ex.Message });
            }
            finally
            {
                loading = false;
            }
            NavigationManager.NavigateTo("/Admin/Article");

            return await _notice.Success(new NotificationConfig { Message = "创建成功", Description = " 文章以创建成功！"});
        }

        /// <summary>
        /// 获取编辑器文本内容
        /// </summary>
        /// <returns></returns>
        private async Task<string> GetMarkdownValues()
        {
            return await module.InvokeAsync<string>("GetMarkdownValues");
        }

        /// <summary>
        /// 获取编辑器文本内容-过滤板
        /// </summary>
        /// <returns></returns>
        private async Task<string> GetMarkdownValuesToFilterHtml()
        {
            var data = (await module.InvokeAsync<string>("filterHtml")).Replace(" ", "");

            if (data.Length > 500)
                data = data.Substring(0, 500);
            else
                data = data.Substring(0, data.Length - 1);

            return data;
        }

        #region Tag方法

        /// <summary>
        /// tag选中状态
        /// </summary>
        /// <param name="antdTag"></param>
        private void CheckedChange(TagDto antdTag)
        {
            var data = options.First(x => x.Id == antdTag.Id);
            data.Checked = !antdTag.Checked;
            data.Number += 1;
        }

        /// <summary>
        /// 添加tag
        /// </summary>
        private void HandleInputConfirm()
        {
            if (string.IsNullOrWhiteSpace(tagValue))
            {
                CancelInput();
                return;
            }

            if (!(tags != null && tags.Any(x => x.Equals(tagValue))) && !options.Any(x => x.Name.Equals(tagValue)))
                tags.Add(tagValue);


            CancelInput();
        }

        /// <summary>
        /// 清空tag变量
        /// </summary>
        private void CancelInput()
        {
            this.tagValue = "";
            this.inputVisible = false;
        }

        #endregion

        #region 封面上传

        /// <summary>
        /// 封面上传
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private async Task LoadFiles(InputFileChangeEventArgs e)
        {
            if (!imageContentType.Any(x=>x.Equals(e.File.ContentType)))
                return;

            if (!url.Equals(imageUrl))
                File.Delete(Path.GetFullPath(imageUrl));

            imageUrl = baseUrl + Guid.NewGuid().ToString("N") + ".png";
            try
            {
                await using FileStream fs = new(imageUrl, FileMode.Create);
                await e.File.OpenReadStream(5120000).CopyToAsync(fs);
            }
            catch (Exception ex)
            {
                //错误处理
                return;
            }

            //获取项目的启动地址
            var host = conf.GetValue(typeof(String), "URLS");
            await module.InvokeVoidAsync("BGroundImage",host + imageUrl.Substring(7));
        }

        private async Task InputFileClick()
        {
           await module.InvokeVoidAsync("InputFileClick");
        }

        #endregion

    }
}

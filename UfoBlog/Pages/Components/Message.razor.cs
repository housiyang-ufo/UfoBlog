using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using UfoBlog.Domain.Dto.OnStage;
using UfoBlog.Domain.Dto.Article;
using Microsoft.EntityFrameworkCore;

namespace UfoBlog.Pages.Components
{
    public partial class Message
    {
        private readonly string[] color = { "#f50", "#2db7f5", "#87d068", "#108ee9", "HotPink", "DarkRed", "rgb(143, 201, 146)", "rgb(105, 58, 236)" };

        #region 生命周期方法

        /// <summary>
        /// 生命周期事件-渲染前
        /// </summary>
        /// <returns></returns>
        protected override async Task OnInitializedAsync()
        {
            using var client = new HttpClient();

            var response = await client.GetAsync($"{conf.GetSection("DataList")["WordStr"]}?c=i");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                wordStr = JsonSerializer.Deserialize<WordString>(data, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }

            using var context = _dbFactory.CreateDbContext();
            tagDto = await context.Tag
                 .Where(x => !x.IsDelete)
                 .OrderByDescending(x => x.CreateTime)
                 .Select(x => _mapper.Map<TagDto>(x))
                 .ToListAsync();
        }
        
        #endregion

        /// <summary>
        /// Tag随机颜色
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private string SwitchColor(int index)
        {
            int i;
            if (index <= 8)
            {
                i = index - 1;
            }
            else
            {
                i = (index % 8) - 1;
            }

            return color[i];
        }
    }
}

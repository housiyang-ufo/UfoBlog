using AntDesign;
using System.Linq;
using System.Threading.Tasks;

namespace UfoBlog.Shared
{
    public partial class NavMenu
    {
        protected override void OnInitialized()
        {
            using var context = _dbFactory.CreateDbContext();
            user = context.Admin.First();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
        #region
            //var client = new HttpClient();
            //var resqonse = await client.GetAsync(Image);
            //var stream = await resqonse.Content.ReadAsStreamAsync();

            //byte[] bytes = new byte[stream.Length];
            //stream.Read(bytes, 0, bytes.Length);


            //var filestream = new FileStream("./Iimage.jpg", FileMode.Create, FileAccess.Write);
            //var binarytWite = new BinaryWriter(filestream);
            //binarytWite.Write(bytes, 0, bytes.Length);
            //binarytWite.Close();
            //binarytWite.Dispose(); 
        #endregion

        if (firstRender)
            {
                await iconService.CreateFromIconfontCN(_configuration.GetSection("DataList")["iconfont"]);
            }
        }

        /// <summary>
        /// 提升信息
        /// </summary>
        /// <returns></returns>
        private async Task<NotificationRef> GetNotification()
        {
            return await _notice.Info(new NotificationConfig { Message = "暴躁提示", Description = "那个坑比，他没写！放了假功能在这！" });
        }

        private async Task NavigateToLogin()
        {
            var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
            if (authState.User.Identity.IsAuthenticated)
                NavigationManager.NavigateTo("/Admin/Index");
            else
                NavigationManager.NavigateTo("Login");

        }
    }
}

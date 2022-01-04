using AntDesign;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.DataProtection;
using System;
using System.Threading.Tasks;

namespace UfoBlog.Pages.Components
{
    public partial class Login
    {
        #region 生命周期方法

        /// <summary>
        /// 生命周期事件-渲染后
        /// </summary>
        /// <param name="firstRender"></param>
        /// <returns></returns>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                if (!string.IsNullOrWhiteSpace(Success) && Success.Equals("True"))
                   await _notice.Error(new NotificationConfig { Message = "错误提示", Description = "账号或密码不正确" });
            }
        }

        #endregion

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="editContext"></param>
        private async Task<NotificationRef> OnFinish(EditContext editContext)
        {
            if (string.IsNullOrWhiteSpace(model.Username) || string.IsNullOrWhiteSpace(model.Password))
                return await _notice.Error(new NotificationConfig { Message = "错误提示", Description = "账号密码不能为空！" });

            //账号密码加密处理
            var dataProtect = _dataProtectionProvider.CreateProtector("Login");
            var input = dataProtect.Protect($"{model.Username}|{model.Password}");

            NavigationManager.NavigateTo("/api/Account/Login?token=" + input, true);
            return null;
        }

        private void OnFinishFailed(EditContext editContext)
        {
            Console.WriteLine($"登录失败:请输入用户名和秘密");
        }
    }
}

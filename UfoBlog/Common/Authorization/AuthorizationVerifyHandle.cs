using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UfoBlog.Common.Authorization
{
    public class AuthorizationVerifyHandle : AuthorizationHandler<AuthorizationVerifyRequirement>
    {
        /// <summary>
        /// 处理程序
        /// </summary>
        /// <param name="context"></param>
        /// <param name="requirement"></param>
        /// <returns></returns>
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AuthorizationVerifyRequirement requirement)
        {
            //校验是否登录
            if (context.User.Identity.IsAuthenticated) 
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}

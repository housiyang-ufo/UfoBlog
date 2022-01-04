using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UfoBlog.Common.Authorization
{
    public class AuthorizationVerifyAttribute : AuthorizeAttribute
    {
        public AuthorizationVerifyAttribute():base("AuthorizationVerify")
        { 
            
        }
    }
}

using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UfoBlog.Domain.Extensions
{
    public static class SettingExtensions
    {
        /// <summary>
        /// 数据库连接串
        /// </summary>
        public const string connectionStrings = "Data Source=BlogContext.db";
    }
}

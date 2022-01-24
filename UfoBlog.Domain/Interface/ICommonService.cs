using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UfoBlog.Domain.Interface
{
   public interface ICommonService
    {
        /// <summary>
        /// 加载指定json文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="name">文件名</param>
        /// <returns></returns>
        IConfiguration LoadJsonFile(string path, string name = "appsettings.json");

        /// <summary>
        /// 相对时间转换 
        /// </summary>
        /// <param name="dynamicTime"></param>
        /// <returns></returns>
        string GetIntervalTime(DateTime dynamicTime);
    }
}

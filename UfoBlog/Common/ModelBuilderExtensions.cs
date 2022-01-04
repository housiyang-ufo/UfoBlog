using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Nancy.Json;
using System;
using System.Collections.Generic;

namespace UfoBlog.Common
{
    /// <summary>
    /// 扩展方法
    /// </summary>
    public static class ModelBuilderExtensions
    {
        /// <summary>
        /// 去除表名复数
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void RemovePluralizingTableNameConvention(this ModelBuilder modelBuilder)
        {
            foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName(entity.DisplayName());
            }
        }

        /// <summary>
        /// 将object对象转换为实体对象
        /// </summary>
        /// <typeparam name="T">实体对象类名</typeparam>
        /// <param name="asObject">object对象</param>
        /// <returns></returns>
        public static T ConvertObjectByJson<T>(this object asObject) where T : new()
        {
            var serializer = new JavaScriptSerializer();
            //将object对象转换为json字符
            var json = serializer.Serialize(asObject);
            //将json字符转换为实体对象
            var t = serializer.Deserialize<T>(json);
            return t;
        }
    }
}

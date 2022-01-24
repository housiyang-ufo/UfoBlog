using System;
using Nancy.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.Linq;

namespace UfoBlog.Domain.Common
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
        /// 批量注入--服务自动注入
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection BatchInjection(this IServiceCollection services)
        {
            //获取service程序集列表
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(x=>x.GetName().FullName.Contains("UfoBlog"));
            
            foreach (Assembly assembly in assemblies)
            {
                //获取程序集下所有类
                Type[] types = assembly.GetTypes();
                types.ToList().ForEach(t =>
                {
                    //非接口，非抽象类
                    if (!t.IsInterface && !t.IsAbstract)
                    {
                        Type[] interfaces = t.GetInterfaces();
                        //注入
                        interfaces.ToList().ForEach(r =>
                        {
                            //跳过Refit注册（暂时没有其他方法）
                            if (!r.FullName.Contains("IAccountClient"))
                                services.AddTransient(r, t);
                        });
                    }
                });
            }

            return services;
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

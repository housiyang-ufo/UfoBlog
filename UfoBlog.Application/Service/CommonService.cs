using System;
using System.IO;
using AutoMapper;
using System.Linq;
using UfoBlog.Domain.Model;
using System.Linq.Expressions;
using UfoBlog.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace UfoBlog.Application.Service
{
    public class CommonService : ICommonService
    {
        //private readonly IMapper _mapper;
        private readonly IDbContextFactory<BlogContext> _dbFactory;

        public CommonService(IDbContextFactory<BlogContext> dbFactory)
        {
            //_mapper = mapper;
            _dbFactory = dbFactory;
        }

        /// <summary>
        /// 加载指定json文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="name">文件名</param>
        /// <returns></returns>
        public IConfiguration LoadJsonFile(string path, string name = "appsettings.json")
        {
            return new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory() + path)
            .AddJsonFile(name).Build();
        }

        /// <summary>
        /// 相对时间转换 
        /// </summary>
        /// <param name="dynamicTime"></param>
        /// <returns></returns>
        public string GetIntervalTime(DateTime dynamicTime)
        {
            DateTime currentDate = DateTime.Now;
            TimeSpan ts = currentDate - dynamicTime;
            int month = (currentDate.Year - dynamicTime.Year) * 12 + (currentDate.Month - dynamicTime.Month);
            string en;
            if (month >= 12)
            {
                int year = month / 12;
                en = year + "年前";
            }
            else if (month > 0)
            {
                en = month + "个月前";
            }
            else if (ts.Days != 0)
            {
                en = ts.Days + "天前";
            }
            else if (ts.Hours != 0)
            {
                en = ts.Hours + "小时前";
            }
            else if (ts.Minutes != 0)
            {
                en = ts.Minutes + "分钟前";
            }
            else if (ts.Seconds != 0)
            {
                en = ts.Seconds + "秒前";
            }
            else
            {
                en = ts.Milliseconds + "毫秒前";
            }
            return en;
        }

        /// <summary>
        /// DB查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="S"></typeparam>
        /// <param name="whereLamdba"></param>
        /// <param name="isAsc"></param>
        /// <param name="orderLamdba"></param>
        /// <returns></returns>
        public IQueryable<T> GetFindList<T,S>(Expression<Func<T, bool>> whereLamdba, bool isAsc, Expression<Func<T, S>> orderLamdba) where T : class
        {
            using var context = _dbFactory.CreateDbContext();

            var list = context.Set<T>().Where(whereLamdba);
            if (isAsc) list = list.OrderBy(orderLamdba);
            else list = list.OrderByDescending(orderLamdba);

            return list;
        }
    }
}

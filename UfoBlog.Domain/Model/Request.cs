using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UfoBlog.Domain.Model
{
    /// <summary>
    /// 返回类型，请求类型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Request<T> 
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
    }
}

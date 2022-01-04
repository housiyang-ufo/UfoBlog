using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UfoBlog.Domain.Dto.OnStage
{
    /// <summary>
    /// 一言
    /// </summary>
    public class WordString
    {
        /// <summary>
        /// 一言标识
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 一言正文。编码方式 unicode。使用 utf-8。
        /// </summary>
        public string Hitokoto { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 一言的出处
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// 一言的作者
        /// </summary>
        public string From_who { get; set; }

        /// <summary>
        /// 添加者
        /// </summary>
        public string Creator { get; set; }

        /// <summary>
        /// 添加者用户标识
        /// </summary>
        public int Creator_uid { get; set; }

        /// <summary>
        /// 审核员标识
        /// </summary>
        public int Reviewer { get; set; }

        /// <summary>
        /// 一言唯一标识；可以链接到 https://hitokoto.cn?uuid=[uuid] (opens new window)查看这个一言的完整信息
        /// </summary>
        public string Uuid { get; set; }

        /// <summary>
        /// 提交方式
        /// </summary>
        public string Commit_from { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public string Created_at { get; set; }

        /// <summary>
        /// 句子长度
        /// </summary>
        public int Length { get; set; } 
    }
}

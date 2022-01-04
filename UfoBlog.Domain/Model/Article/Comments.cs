namespace UfoBlog.Domain.Model.Article
{
    public class Comments : BaseModel
    {
        public int Id { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 作者id
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 类型 1：一级评论 2：二级评论
        /// </summary>
        public int Type { get; set; }
    }
}

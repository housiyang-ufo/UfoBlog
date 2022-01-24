using UfoBlog.Domain.Common;
using UfoBlog.Domain.Model.Article;
using Microsoft.EntityFrameworkCore;


namespace UfoBlog.Domain.Model
{
    /// <summary>
    /// 数据库上下文
    /// </summary>
    public class BlogContext : DbContext
    {

        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        #region 实体对应表
        /// <summary>
        /// 标签表
        /// </summary>
        public DbSet<Tag> Tag { get; set; }

        /// <summary>
        /// 管理员表
        /// </summary>
        public DbSet<Admin> Admin { get; set; }

        /// <summary>
        /// 标签-文章映射表
        /// </summary>
        public DbSet<TagMap> TagMap { get; set; }

        /// <summary>
        /// 点赞记录表
        /// </summary>
        public DbSet<LikeIt> LikeIt { get; set; }

        /// <summary>
        /// 阅读记录表
        /// </summary>
        public DbSet<ViewNum> ViewNum { get; set; }

        /// <summary>
        /// 文章表
        /// </summary>
        public DbSet<Article.Article> Article { get; set; }

        /// <summary>
        /// 文章分类表
        /// </summary>
        public DbSet<Category> Category { get; set; }

        /// <summary>
        /// 个人动态
        /// </summary>
        public DbSet<DynamicMan> DynamicMan { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //去除表名复数
            modelBuilder.RemovePluralizingTableNameConvention();

            base.OnModelCreating(modelBuilder);
        }
    }
}

using AutoMapper;
using UfoBlog.Domain.Dto.Article;
using UfoBlog.Domain.Model.Article;

namespace UfoBlog.Domain.Mapper
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<Article, ArticleDto>().ReverseMap();

            CreateMap<Category, CategoryDto>().ReverseMap();

            CreateMap<Tag, TagDto>().ReverseMap();

            CreateMap<DynamicMan, DynamicManDto>()
                .ForMember(dest => dest.IsLikeIt, opt => opt.MapFrom(o => false)).ReverseMap();
        }
    }
}

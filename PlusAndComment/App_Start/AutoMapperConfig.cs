using AutoMapper;
using PlusAndComment.Models;
using PlusAndComment.Models.Entities;
using System.Collections.Generic;
using static PlusAndComment.Common.Enums;

namespace PlusAndComment.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            ConfigurePostMapping();
        }

        private static void ConfigurePostMapping()
        {
            //var config = new MapperConfiguration(cfg =>
            //{
            //cfg.CreateMap<HomeVM, ICollection<PostEntity>>()
            //    .ForMember(d => d, opt => opt.MapFrom(src => src.Posts));
            //cfg.CreateMap< ICollection < PostEntity > , HomeVM >()
            //    .ForMember(d => d.Posts, opt => opt.MapFrom(src => src));
            //cfg.AddProfile<AppProfile>();

            //cfg.CreateMap<PostEntity, PostDetailsVM>();

            //});

            //IMapper mapper = config.CreateMapper();

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<PostDetailsVM, PostEntity>();

                cfg.CreateMap<MainPostVM, PostEntity>()
                .ForMember(m => m.Posts, opt => opt.MapFrom(c => c.Posts));

                cfg.CreateMap<PostEntity, MainPostVM>()
                .ForMember(m => m.Posts, opt => opt.MapFrom(c => c.Posts))
                .ForMember(x => x.AmountOfAllcommens, opt => opt.Ignore());

                cfg.CreateMap<AddPostVM, PostEntity>()
                .ForMember(m => m.PostType, opt => opt.MapFrom(c => c.Type));

                cfg.CreateMap<PostEntity,AddPostVM>()
                .ForMember(m => m.Type, opt => opt.MapFrom(c => c.PostType));

                cfg.CreateMap<UserProfileSettings, UserProfileSettingsVM>();
                cfg.CreateMap<UserProfileSettingsVM,UserProfileSettings>();

                cfg.CreateMap<ArticleVM, ArticleEntity>()
                .ForMember(m => m.Url, opt => opt.MapFrom(c => c.Url));

                cfg.CreateMap<ArticleEntity, ArticleVM>()
                .ForMember(m => m.Url, opt => opt.MapFrom(c => c.Url));

                cfg.CreateMap<SucharEntity, SucharVM>();
                cfg.CreateMap<SucharVM, SucharEntity>();


                //cfg.CreateMap<ICollection<PostEntity>, ICollection<MainPostVM>>();
                //cfg.CreateMap< ICollection <MainPostVM>, ICollection <PostEntity>>();
            });

            //config.AssertConfigurationIsValid();
            //Mapper.Initialize(config);
            //var source = new HomeVM();
            //var dest = mapper.Map<HomeVM, ICollection<PostEntity>>(source);

        }
    }
}
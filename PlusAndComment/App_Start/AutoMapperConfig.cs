using AutoMapper;
using PlusAndComment.Models;
using PlusAndComment.Models.AddPostVMs;
using PlusAndComment.Models.Entities;
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
                cfg.CreateMap<PostVM, PostEntity>();

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

                cfg.CreateMap<AddArticleVM, ArticleEntity>()
                .ForMember(m => m.Url, opt => opt.MapFrom(c => c.Url));

                cfg.CreateMap<ArticleEntity, AddArticleVM>();

                cfg.CreateMap<SucharEntity, AddSucharVM>();
                cfg.CreateMap<AddSucharVM, SucharEntity>();

                cfg.CreateMap<AddPictureFromDiskVM, PostEntity>();
                cfg.CreateMap<AddHumourVM, PostEntity>();

                cfg.CreateMap<ArticleVM, ArticleEntity>();
                cfg.CreateMap<ArticleEntity, ArticleVM>();

                cfg.CreateMap<SucharVM, SucharEntity>();
                cfg.CreateMap<SucharEntity, SucharVM>();

                //cfg.CreateMap<AddLinkVM, PostEntity>()
                //.ForMember(target => target.EmbedUrl, src =>
                //{
                //    src.Condition(s => s.Type == PostType.gif);
                //    src.MapFrom(s => s.Gif.FirstFramePathRelative);
                //})
                //.ForMember(target => target.ReferenceUrl, src =>
                //{
                //    src.Condition(s => s.Type == PostType.gif);
                //    src.MapFrom(s => s.Gif.PathRelative);
                //});

                //cfg.CreateMap<AddLinkVM, PostEntity>()
                //.ForMember(target => target.EmbedUrl, src =>
                //{
                //    src.Condition(s => s.Type == PostType.img);
                //    src.MapFrom(s => s.Picture.PathRelative);
                //})
                //.ForMember(target => target.ReferenceUrl, src =>
                //{
                //    src.Condition(s => s.Type == PostType.img);
                //    src.MapFrom(s => s.Picture.PathRelative);
                //});


                //.ForMember(target => target.ReferenceUrl, src => src.Condition(s => s.PostType == UIPostType.).MapFrom(c => c.Url));

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
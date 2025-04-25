using AutoMapper;
using GameDiary.Core.Models;
using GameDiary.Dao.Entities;

namespace GameDiary.Bll.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<GameEntity, Game>()
                .ForMember(dest => dest.GameDevelopers, opt => opt.MapFrom(src => src.GameDevelopers))
                .ForMember(dest => dest.GamePublishers, opt => opt.MapFrom(src => src.GamePublishers));

            CreateMap<GameDeveloperEntity, GameDeveloper>()
                .ForMember(dest => dest.GameId, opt => opt.MapFrom(src => src.GameId))
                .ForMember(dest => dest.DevelopId, opt => opt.MapFrom(src => src.DeveloperId))
                .ForMember(dest => dest.DeveloperEntity, opt => opt.MapFrom(src => src.DevelopEntity));

            CreateMap<GamePublisherEntity, GamePublisher>()
                .ForMember(dest => dest.GameId, opt => opt.MapFrom(src => src.GameId))
                .ForMember(dest => dest.PublisherId, opt => opt.MapFrom(src => src.PublisherId))
                .ForMember(dest => dest.PublisherEntity, opt => opt.MapFrom(src => src.PublisherEntity));

            CreateMap<DevelopEntity, Developer>();
            CreateMap<PublisherEntity, Publisher>();
        }
    }
}

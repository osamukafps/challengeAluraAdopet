using AutoMapper;
using ChallengeAluraAdopet.API.DTO;
using ChallengeAluraAdopet.API.Models;

namespace ChallengeAluraAdopet.API.Config;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<Tutor, TutorDTO>().ReverseMap();
        });

        return mappingConfig;
    }
}
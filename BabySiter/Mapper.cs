using AutoMapper;
using DTO;
using Entity;

namespace BabySiter
{
    public class Mapper:Profile
    {
public Mapper()
        {
            CreateMap<Babysiter, BabySiterDTO>();
            CreateMap<BabySiterDTO, Babysiter>();
            CreateMap<SearchBabysiter,SearchBabySiterDTO >();
            CreateMap< SearchBabySiterDTO, SearchBabysiter >();
            CreateMap<Time,TimeDTO>();
            CreateMap<TimeDTO, Time>();
            CreateMap<RequsetSearchBabysiter, RequsetSearchBabysiterDTO>();
            CreateMap<NeighborhoodBabysiter, NeighborhoodBabysiterDTO>();
            CreateMap< NeighborhoodBabysiterDTO, NeighborhoodBabysiter>();

        }

    }
}

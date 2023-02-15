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
            
            CreateMap<Time,TimeDTO>();
        }

    }
}

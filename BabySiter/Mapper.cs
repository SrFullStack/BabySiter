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
            CreateMap<SearchBabysiter,SearchBabySiterDTO >();
        }

    }
}

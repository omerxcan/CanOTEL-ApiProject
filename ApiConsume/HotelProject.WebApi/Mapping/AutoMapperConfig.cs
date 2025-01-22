using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Room,AddRoomDto>().ReverseMap();
            CreateMap<Room,UpdateRoomDto>().ReverseMap();
        }
    }
}

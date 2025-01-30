using AutoMekanik.BLL.RequestModels;
using AutoMekanik.BLL.ResponseModels;
using AutoMekanik.Domain.Entities;
using AutoMapper;

namespace AutoMekanik.BLL.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Mapping from BookingRequestModel to Booking entity
            CreateMap<BookingRequestModel, Booking>()
                .ForMember(dest => dest.CarId, opt => opt.MapFrom(src => src.CarId))
                .ForMember(dest => dest.MechanicId, opt => opt.MapFrom(src => src.MechanicId))
                .ForMember(dest => dest.AppointmentDate, opt => opt.MapFrom(src => src.AppointmentDate));

            // Mapping from Booking entity to BookingResponseModel
            CreateMap<Booking, BookingResponseModel>()
                .ForMember(dest => dest.CarBrand, opt => opt.MapFrom(src => src.Car.Brand))  // Map Car's Brand property
                .ForMember(dest => dest.MechanicName, opt => opt.MapFrom(src => src.Mechanic.Name));  // Assuming Mechanic has a Name property
        }
    }
}

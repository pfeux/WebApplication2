using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.AutoMap
{
    public class AutoMapConfigure
    {
        public static IMapper AutoMapper { get; private set; }

        public static void Map()
        {
            var config = new MapperConfiguration(Configure);
            AutoMapper = config.CreateMapper();
        }

        private static void Configure(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<CarViewModel, Car>()
                .ForMember(dest => dest.BodyType, src => src.Ignore())
                .ForMember(dest => dest.Vehicle, src => src.Ignore())

                .ForMember(dest => dest.BodyTypeID, src => src.MapFrom(s => Convert.ToInt32(s.BodyType)));

            cfg.CreateMap<CarViewModel, Vehicle>()
                .ForMember(dest => dest.Car, src => src.Ignore())
                .ForMember(dest => dest.VehicleType, src => src.Ignore())

                .ForMember(dest => dest.ID, src => src.MapFrom(s => s.VehicleID))
                .ForMember(dest => dest.VehicleTypeID, src => src.MapFrom(s => Convert.ToInt32(s.VehicleType)));

            cfg.CreateMap<VehicleType, VehicleTypeViewModel>();

            cfg.CreateMap<BodyType, BodyTypeViewModel>();
        }
    }
}

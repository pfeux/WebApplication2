using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.AutoMap;
using WebApplication2.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Extensions
{
    public static class MappingExtension
    {
        public static TDestination MapTo<TSource, TDestination>(this TSource source)
        {
            var mapper = AutoMapConfigure.AutoMapper;
            return mapper.Map<TSource, TDestination>(source);
        }

        public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination)
        {
            var mapper = AutoMapConfigure.AutoMapper;
            return mapper.Map(source, destination);
        }

        public static Car ToEntity(this CarViewModel model)
        {
            return model.MapTo<CarViewModel, Car>();
        }

        public static Car ToEntity(this CarViewModel model, Car destination)
        {
            return model.MapTo(destination);
        }

        public static Vehicle ToVehicleEntity(this CarViewModel model)
        {
            return model.MapTo<CarViewModel, Vehicle>();
        }

        public static Vehicle ToVehicleEntity(this CarViewModel model, Vehicle destination)
        {
            return model.MapTo(destination);
        }

        public static VehicleTypeViewModel ToModel(this VehicleType entity)
        {
            return entity.MapTo<VehicleType, VehicleTypeViewModel>();
        }

        public static BodyTypeViewModel ToModel(this BodyType entity)
        {
            return entity.MapTo<BodyType, BodyTypeViewModel>();
        }
    }
}

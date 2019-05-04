using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Extensions;
using WebApplication2.Models;
using WebApplication2.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    public class VehicleController : Controller
    {
        private readonly CarSalesDbContext dbContext;

        public VehicleController(CarSalesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost("[action]")]
        public void CarInsert([FromBody] CarViewModel car)
        {
            if (!ModelState.IsValid)
                throw new Exception("Invalid error");

            var c = car.ToEntity();
            var vehicle = car.ToVehicleEntity();

            vehicle.Car = c;
            dbContext.Vehicle.Add(vehicle);
            dbContext.SaveChanges();
        }

        [HttpGet("[action]")]
        public IEnumerable<VehicleTypeViewModel> GetVehicleType()
        {
            var vehicletypes = dbContext.VehicleType.Select(v => v.ToModel());
            return vehicletypes.ToList();
        }

        [HttpGet("[action]")]
        public IEnumerable<BodyTypeViewModel> GetBodyType()
        {
            var bodytypes = dbContext.BodyType.Select(b => b.ToModel());
            return bodytypes.ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Vehicle
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int VehicleTypeID { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        public virtual Car Car { get; set; }

        [ForeignKey("VehicleTypeID")]
        public virtual VehicleType VehicleType { get; set; }
    }

}

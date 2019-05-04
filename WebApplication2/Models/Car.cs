using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Car 
    {
        [Key]
        public int VehicleID { get; set; }

        [Required]
        public string Engine { get; set; }

        [Required, Range(1, 10)]
        public int Doors { get; set; }

        [Required, Range(1, 25)]
        public int Wheels { get; set; }

        [Required]
        public int BodyTypeID { get; set; }

        [ForeignKey("VehicleID")]
        public virtual Vehicle Vehicle { get; set; }

        [ForeignKey("BodyTypeID")]
        public virtual BodyType BodyType { get; set; }
    }
}

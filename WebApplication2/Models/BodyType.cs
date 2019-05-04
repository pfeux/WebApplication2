using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class BodyType
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Type { get; set; }

        public virtual List<Car> Cars { get; set; }
    }
}

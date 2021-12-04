using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    interface IVehicle
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string BrandName { get; set; }
    }
}

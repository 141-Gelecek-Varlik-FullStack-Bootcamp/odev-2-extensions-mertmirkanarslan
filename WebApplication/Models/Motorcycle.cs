using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Motorcycle : IVehicle
    {
        //IVehicle interface'inden implemente edilen proplar
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ModelYear { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string BrandName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //Motorcycle class'ına ozgu olan proplar
        public int GearNumber { get; set; }
        public bool IsScooter { get; set; }
    }
}

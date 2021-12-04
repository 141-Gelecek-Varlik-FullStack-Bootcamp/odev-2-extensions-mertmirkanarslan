using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Car : IVehicle
    {
        //IVehicle interface'inden ID, Model, ModelYear ve BrandName propertylerini implemente ettik.
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ModelYear { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string BrandName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //interface'in disinda kalan metot
        public int DoorNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsDiesel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}

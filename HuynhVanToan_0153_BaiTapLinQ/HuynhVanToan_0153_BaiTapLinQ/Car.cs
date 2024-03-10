using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuynhVanToan_0153_BaiTapLinQ
{
    class Car: Vehicle
    {
        public int NumDoors { get; set; }
        public string BodyType { get; set; }
        public Car(string make, string model, int year, decimal price, int numDoors, string bodyType)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            NumDoors = numDoors;
            BodyType = bodyType;
        }
    }
}

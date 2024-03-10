using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuynhVanToan_0153_BaiTapLinQ
{
    class Truck: Vehicle
    {
        public decimal Payload { get; set; }
        public decimal TowCapacity { get; set; }
        public Truck(string make, string model, int year, decimal price, decimal payload, decimal towCapacity)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            Payload = payload;
            TowCapacity = towCapacity;
        }
    }
}

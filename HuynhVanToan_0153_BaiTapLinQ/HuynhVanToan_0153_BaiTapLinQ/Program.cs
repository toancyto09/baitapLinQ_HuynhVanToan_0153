using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuynhVanToan_0153_BaiTapLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tao danh sach cac Car
            List<Car> cars = new List<Car>()
            {
                new Car("Toyota", "Camry", 2023, 250000, 4, "Sedan"),
                new Car("Honda", "Accord", 2022, 225000, 4, "Sedan"),
                new Car("Ford", "F-150", 2021, 400000, 2, "Truck"),
                new Car("Chevrolet", "Silverado", 2020, 350000, 2, "Truck"),
                new Car("Tesla", "Model 3", 2023, 450000, 4, "Sedan"),
            };
            //Hien thi cac gia tri trong khoan 100.000 đến 250.000
            var filteredCars = cars.Where(car => car.Price >= 100000 && car.Price <= 250000);
            Console.WriteLine("===================================");
            Console.WriteLine("Xe co gia tri trong khoang 100000 den 250000") ;
            foreach(var car in filteredCars)
            {
                Console.WriteLine(car);
            }
            //Cac xe co nam san xuat > 1990
            var yearCars = cars.Where(car => car.Year > 1990);
            Console.WriteLine("===================================");
            Console.WriteLine("Xe co nam san xuat > 1990");
            foreach (var car in yearCars)
            {
                Console.WriteLine(car);
            }
            //cac xe theo hang va tong gia tri theo nhom
            var carGroups = cars.GroupBy(car => car.Make)
                    .Select(group => new { Make = group.Key, TotalPrice = group.Sum(car => car.Price) });
            Console.WriteLine("===================================");
            Console.WriteLine("Cac xe theo hang va tong gia tri theo hang");
            foreach (var group in carGroups)
            {
                Console.WriteLine($"{group.Make}: {group.TotalPrice:n}");
            }
            //Danh sach xe tai
            var trucks = new List<Truck>()
                {
                    new Truck("Ford", "F-150", 2023, 400000, 3500, 10000),
                    new Truck("Chevrolet", "Silverado", 2022, 350000, 3000, 8500),
                    new Truck("Ram", "1500", 2021, 320000, 2500, 7500),
                    new Truck("Toyota", "Tundra", 2020, 300000, 2000, 6500),
                    new Truck("GMC", "Sierra", 2019, 280000, 1500, 5500),
                };

            //Hien thi danh sach theo nam san xuat moi nhat
            trucks.Sort((x, y) => y.Year.CompareTo(x.Year));
            Console.WriteLine("===================================");
            Console.WriteLine( "Danh sach theo nam san xuat moi nhat");
            foreach (var truck in trucks)
            {
                Console.WriteLine(truck);
            }
            //Hien thi ten cty chu quan cua Truck
            var companies = new Dictionary<string, string>()
            {
                { "Ford", "Ford Motor Company" },
                { "Chevrolet", "General Motors" },
                { "Ram", "Stellantis" },
                { "Toyota", "Toyota Motor Corporation" },
                { "GMC", "General Motors" },
            };
            Console.WriteLine("=====================================");
            Console.WriteLine("Ten cong ty chu quan cua Truck");

            var truckWithCompany = from truck in trucks
                                   join company in companies on truck.Make equals company.Key
                                   select new { Truck = truck, Company = company.Value };

            foreach (var item in truckWithCompany)
            {
                Console.WriteLine($"{item.Truck.Make} - {item.Company}");
            }


            Console.ReadLine();
        }
    }
}

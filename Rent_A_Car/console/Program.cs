using Business.Concrate;
using DataAccess.Abstract;
using DataAccess.Concrate.EntityFramework;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  CarTest();
            // BrandTest();
            CarManager carManager = new CarManager(new EfCarManager());
            foreach (var item in carManager.GetByDetails())
            {
                Console.WriteLine(item.Id+"/"+item.BrandName+"/"+item.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandManager());
            brandManager.Delete(new Brand { BrandId = 17, BrandName = "Mercedes" });
            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine(item.BrandName);
            }
        }

        private static void CarTest()
        {
            Car newcar = new Car { Id = 1, BrandId = 11, ColorId = 12, ModelYear = 2003, DailyPrice = 0, CarName = "updated car" };
            CarManager carManager = new CarManager(new EfCarManager());
            foreach (Car car in carManager.GetAll())
            {
                Console.WriteLine("Id: " + car.Id +
                                  "\nBrandId: " + car.BrandId +
                                  "\nColorId: " + car.ColorId +
                                  "\nModelYear: " + car.ModelYear +
                                  "\nDailyPrice: " + car.DailyPrice);
                Console.WriteLine("-----------------------------------");
            }
            Console.WriteLine("After uptade");
            carManager.Update(newcar);
            foreach (Car car in carManager.GetAll())
            {
                Console.WriteLine("Id: " + car.Id +
                                  "\nBrandId: " + car.BrandId +
                                  "\nColorId: " + car.ColorId +
                                  "\nModelYear: " + car.ModelYear +
                                  "\nDailyPrice: " + car.DailyPrice);
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}

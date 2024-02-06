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
            //Id, BrandId, ColorId, ModelYear, DailyPrice
        }
    }
}

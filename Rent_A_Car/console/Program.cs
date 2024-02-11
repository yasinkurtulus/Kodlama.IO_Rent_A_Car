using Business.Concrate;
using Core.Utilities.Results;
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
            RentalManager rentalManager = new RentalManager(new EfRentalManager());
            Rental rent1 = new Rental { Id = 1, CarId = 11, RentDate = DateTime.Now, ReturnDate = DateTime.Now };
            Rental rent2 = new Rental { Id = 2, CarId = 11, RentDate = DateTime.Now,ReturnDate=null};
            Rental rent3 = new Rental { Id = 3, CarId = 12, RentDate = DateTime.Now,ReturnDate=null};                      
            Console.WriteLine(rentalManager.Add(rent3).Message);
           
         

        }

        private static void CarAdd(Car car)
        {
            CarManager carManager = new CarManager(new EfCarManager());
            var result = carManager.Add(car);
            if (result.Succes==true) {
                Console.WriteLine(result.Message);
            }
            else { Console.WriteLine(result.Message); } 
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandManager());
            brandManager.Delete(new Brand { BrandId = 17, BrandName = "Mercedes" });
            foreach (var item in brandManager.GetAll().Data)
            {
                Console.WriteLine(item.BrandName);
            }
        }

        private static void CarUpdate()
        {
            Car newcar = new Car { Id = 5, BrandId = 11, ColorId = 12, ModelYear = 2003, DailyPrice = 1000, CarName = "updated car" };
            CarManager carManager = new CarManager(new EfCarManager());
            foreach (Car car in carManager.GetAll().Data)
            {
                Console.WriteLine("Id: " + car.Id +
                                  "\nBrandId: " + car.BrandId +
                                  "\nColorId: " + car.ColorId +
                                  "\nModelYear: " + car.ModelYear +
                                  "\nDailyPrice: " + car.DailyPrice);
                Console.WriteLine("-----------------------------------");
            }
           /* Console.WriteLine("after update");
            var result = carManager.Update(newcar);
            if (result.Succes == true)
            {
                Console.WriteLine(result.Message);
                foreach (Car car in carManager.GetAll().Data)
                {
                    Console.WriteLine("Id: " + car.Id +
                                      "\nBrandId: " + car.BrandId +
                                      "\nColorId: " + car.ColorId +
                                      "\nModelYear: " + car.ModelYear +
                                      "\nDailyPrice: " + car.DailyPrice);
                    Console.WriteLine("-----------------------------------");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }*/





        }
        private static void CarGetCategoryId(int id)
        {
            CarManager carManager = new CarManager(new EfCarManager());
            var result = carManager.GetByBrandId(id);
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.CarName+" / "+item.BrandId);
            }
        }
    }
}

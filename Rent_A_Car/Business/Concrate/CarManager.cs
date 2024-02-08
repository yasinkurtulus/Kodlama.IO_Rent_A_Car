using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class CarManager : ICarService
    {
        ICarDal icardal;
        public CarManager(ICarDal ıcd)
        {
            icardal = ıcd;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length > 2&&car.DailyPrice>0)
            {
                icardal.Add(car);
            }
            else
            {
                Console.WriteLine("price must be bigger than" +
                              " 0 and car name lenght must be bigger than 2");
            }
        }

        public void Delete(Car car)
        {
            foreach (var item in GetAll())
            {
                if (car.Id == item.Id)
                {
                    icardal.Delete(car);
                    return;
                }

            }
            Console.WriteLine("There is no car ıd with "+car.Id);
        }

        public List<Car> GetAll()
        {
          return  icardal.GetAll();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return icardal.GetAll().Where(p => p.BrandId == brandId).ToList();
        }

        public List<Car> GetByColorId(int colorId)
        {
            return icardal.GetAll().Where(p => p.ColorId == colorId).ToList();
        }

        public List<CarDetailDto> GetByDetails()
        {
            return icardal.GetByDetails();
        }

        public void Update(Car car)
        {
            foreach (var item in GetAll())
            {
                if (car.Id == item.Id)
                {
                    if (car.CarName.Length > 2 && car.DailyPrice > 0) {
                        icardal.Update(car);
                    }
                    else
                    {
                        Console.WriteLine("price must be bigger than" +
                             " 0 and car name lenght must be bigger than 2");
                    }

                    return;
                }
            }
            Console.WriteLine("There is no car ıd with " + car.Id);
        }
    }
}

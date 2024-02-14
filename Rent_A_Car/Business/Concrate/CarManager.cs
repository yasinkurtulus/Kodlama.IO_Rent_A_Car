using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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

        public IResult Add(Car car)
        {
            if (car.CarName.Length > 2&&car.DailyPrice>0)
            {
                icardal.Add(car);
                return new SuccesResult(Messages.CarAdded);
            }
            else
            {
                return new ErrorResult(Messages.CarNameInValid);
            }
        }

        public IResult Delete(Car car)
        {
            foreach (var item in icardal.GetAll())
            {
                if (car.Id == item.Id)
                {
                    
                    icardal.Delete(car);
                    return new SuccesResult(Messages.CarDeleted);
                }

            }

          return new ErrorResult(Messages.CarCouldntFind);
        }

        public IDataResult<List<Car>> GetAll()
        {
          return  new SuccesDataResult<List<Car>>(icardal.GetAll());
        }

        public IDataResult<List<Car>> GetByBrandId(int brandId)

        {                        
            return new SuccesDataResult<List<Car>>(icardal.GetAll(p => p.BrandId == brandId));                                               
        }

        public IDataResult<List<Car>> GetByColorId(int colorId)
        {
            return new SuccesDataResult<List<Car>>(icardal.GetAll().Where(p => p.ColorId == colorId).ToList());
        }

        public IDataResult<List<CarDetailDto>> GetByDetails()
        {
            return new SuccesDataResult<List<CarDetailDto>>(icardal.GetByDetails());
        }

        public IResult Update(Car car)
        {
            foreach (var item in icardal.GetAll())
            {
                if (car.Id == item.Id)
                {
                    if (car.CarName.Length > 2 && car.DailyPrice > 0) {
                        icardal.Update(car);
                        return new SuccesResult(Messages.CarUpdated);                       
                    }
                    else
                    {
                        return new ErrorResult(Messages.CarPriceInValid);
                    }

                   
                }
            }
            return new ErrorResult(Messages.CarCouldntFind);
        }
    }
}

using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using Microsoft.EntityFrameworkCore.Storage.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal ırd)
        {
            _rentalDal = ırd;
        }
        public IResult Add(Rental rental)
        {
            var _rentalcar = _rentalDal.GetAll(r => r.CarId == rental.CarId);
            if (_rentalcar != null)
            {
                bool canRent = true;
                foreach (var item in _rentalcar)
                {
                    if (item.ReturnDate == null)
                    {
                        canRent = false;
                    }
                }
                if (canRent == true)
                {
                    _rentalDal.Add(rental);
                    return new SuccesResult(Messages.CarRented);
                }
                else
                {
                    return new ErrorResult(Messages.CarCanNotBeRent);
                }
            }
            _rentalDal.Add(rental);
            return new SuccesResult(Messages.CarRented);

        }

        public IResult Delete(Rental rental)
        {
            //BusinesCode
            _rentalDal.Delete(rental);
            return new SuccesResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            //BusinesCode
            return new SuccesDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            //BusinesCode
            return new SuccesDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
        }

        public IResult CarDelivered(int id)
        {
            var result = _rentalDal.Get(r => r.Id == id);
            if (result==null||result.ReturnDate!=null)
            {
                return new ErrorResult(Messages.CarRentDNE);
            }
            _rentalDal.CarDelivered(id);
            return new SuccesResult(Messages.CarDelivere);
        }

        public IResult Update(Rental rental)
        {
            //BusinesCode
            _rentalDal.Update(rental);
            return new SuccesResult();
        }
    }
}

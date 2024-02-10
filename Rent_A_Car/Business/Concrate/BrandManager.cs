using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class BrandManager : IBrandService
    {
        IBrandDal iBrandDal;
        public BrandManager(IBrandDal ibd)
        {
            iBrandDal = ibd;       
        }
        public IResult Add(Brand brand)
        {
            //BusinesCode
            iBrandDal.Add(brand);
           return new SuccesResult();
        }

        public IResult Delete(Brand brand)
        {
            //BusinesCode
            iBrandDal.Delete(brand);
            return new SuccesResult();
        }

        public IDataResult<List<Brand>> GetAll()
        {
            //BusinesCode
            return new SuccesDataResult<List<Brand>>(iBrandDal.GetAll());
            
        }

        public IDataResult<Brand> GetById(int id)
        {
            //BusinesCode
            return new SuccesDataResult<Brand>(iBrandDal.Get(b => b.BrandId == id));
        }

        public IResult Update(Brand brand)
        {
            //BusinesCode
           
            iBrandDal.Update(brand);
            return new SuccesResult();
        }
    }
}

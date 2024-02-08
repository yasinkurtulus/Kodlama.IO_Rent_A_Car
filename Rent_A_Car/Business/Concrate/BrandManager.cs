using Business.Abstract;
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
        public void Add(Brand brand)
        {
            //BusinesCode
            iBrandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            //BusinesCode
            iBrandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            //BusinesCode
            return iBrandDal.GetAll();
        }

        public Brand GetById(int id)
        {
            //BusinesCode
            return iBrandDal.Get(b => b.BrandId == id);
        }

        public void Update(Brand brand)
        {
            //BusinesCode
            iBrandDal.Update(brand);
        }
    }
}

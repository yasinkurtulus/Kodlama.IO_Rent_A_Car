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
    public class ColorManager : IColorService
    {
        IColorDal iColorDal;
        public ColorManager(IColorDal icd)
        {
                iColorDal= icd; 
        }
        public IResult Add(Color color)
        {
            //BusinesCode
           
            iColorDal.Add(color);
            return new SuccesResult();
        }

        public IResult Delete(Color color)
        {
            //BusinesCode
            iColorDal.Delete(color);
            return new SuccesResult();
        }
     
        public IDataResult<List<Color>> GetAll()
        {
            //BusinesCode
            return new SuccesDataResult<List<Color>>(iColorDal.GetAll());
        }

        public IDataResult<Color>GetById(int id)
        {
            //BusinesCode
            return new SuccesDataResult<Color>(iColorDal.Get(b => b.ColorId == id));
        }

        public IResult Update(Color color)
        {
            //BusinesCode
            
            iColorDal.Update(color);
            return new SuccesResult();
        }

    
    }
}

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
    public class ColorManager : IColorService
    {
        IColorDal iColorDal;
        public ColorManager(IColorDal icd)
        {
                iColorDal= icd; 
        }
        public void Add(Color color)
        {
            //BusinesCode
            iColorDal.Add(color);
        }

        public void Delete(Color color)
        {
            //BusinesCode
            iColorDal.Delete(color);
        }
     
        public List<Color> GetAll()
        {
            //BusinesCode
            return iColorDal.GetAll();
        }

        public Color GetById(int id)
        {
            //BusinesCode
            return iColorDal.Get(b => b.ColorId == id);
        }

        public void Update(Color color)
        {
            //BusinesCode
            iColorDal.Update(color);
        }

    
    }
}

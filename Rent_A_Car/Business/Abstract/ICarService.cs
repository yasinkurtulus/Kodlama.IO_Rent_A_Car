using Core.Utilities.Results;
using Entities.Concrate;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetByDetails();
        IDataResult<List<Car>> GetByColorId(int colorId);
        IDataResult<List<Car>>GetByBrandId(int brandId); 
    }
}

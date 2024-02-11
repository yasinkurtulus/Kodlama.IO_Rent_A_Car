using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal csd)
        {
            _customerDal = csd;
        }
        public IResult Add(Customer customer)
        {
            //BusinesCode
            _customerDal.Add(customer);
            return new SuccesResult();
        }

        public IResult Delete(Customer customer)
        {
            //BusinessCode
            _customerDal.Delete(customer);
            return new SuccesResult();
        }

        public IDataResult<List<Customer>> GetAll()
        {
            //BusinessCode
            return new SuccesDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<Customer> GetById(int id)
        {
            //BusinessCode
            return new SuccesDataResult<Customer>(_customerDal.Get(p=>p.UserId==id));
        }

        public IResult Update(Customer customer)
        {
            //BusinessCode
            _customerDal.Update(customer);
            return new SuccesResult();
        }
    }
}

using Business.Abstract;
using Business.Constant;
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
    public class UserManager : IUserService
    {
        IUsersDal _userDal;
        public UserManager(IUsersDal ısd)
        {
            _userDal = ısd;
        }
        public IResult Add(User user)
        {
            //BusinessCode
           var result=_userDal.Get(u=>u.Id == user.Id);
            if (result == null)
            {
                _userDal.Add(user);
                return new SuccesResult();
            }
            return new ErrorResult(Messages.UserAlreadyExist);
           
        }

        public IResult Delete(User user)
        {
            //BusinessCode
            var result = _userDal.Get(u => u.Id == user.Id);
            if (result == null)
            {
                return new ErrorResult(Messages.UserDoesNotExist);
            }
            
            _userDal.Delete(user); 
            return new SuccesResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            //BusinessCode
            return new SuccesDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetByUserId(int id)
        {
            //BusinessCode
            return new SuccesDataResult<User>(_userDal.Get(u => u.Id == id));
        }

        public IResult Update(User user)
        {
            //BusinessCode
            _userDal.Update(user);
            return new SuccesResult();
        }
    }
}

using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUsersDal:IEntityRepository<User>
    {

    }
}

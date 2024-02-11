using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfRentalManager : EfEntityRepositoryBase<Rental, RentCarContext>, IRentalDal
    {
        public void CarDelivered(int id)
        {
            using (RentCarContext context=new RentCarContext())
            {
                var updatedRental = context.Rentals.FirstOrDefault(r => r.Id == id);
                updatedRental.ReturnDate = DateTime.Now;
                context.SaveChanges();
            }
        }
    }
}

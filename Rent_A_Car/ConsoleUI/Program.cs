using Business.Concrate;
using DataAccess.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager productManager1 = new CarManager(new EfCarManager());
            foreach (var product in productManager1.GetAll())
            {
                Console.WriteLine(product.CarId);
            }
            Console.WriteLine("--------------------");


        }
    }
}

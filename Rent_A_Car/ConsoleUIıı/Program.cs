// See https://aka.ms/new-console-template for more information
using Business.Concrate;
using DataAccess.Concrate.EntityFramework;

static void Main(string[] args)
{
   CarManager carManager1 = new CarManager(new EfCarManager());
    foreach (var car in carManager1.GetAll())
    {
        Console.WriteLine(car.CarId);
        Console.WriteLine("dsd");
    }
    Console.WriteLine("--------------------");
    Console.WriteLine("wq");


}

using Business.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Linq;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //CarAddTest(carManager);
            //CarDeleteTest(carManager);
            //GetAllTest(carManager);
            //UpdateTest(carManager);
            //GetById(carManager);
            //GetCarDetailsTest(carManager); join 
            //ResultTest(carManager);
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental = new Rental { CarId = 1, CustomerId = 2, RentDate = DateTime.Now };
            var result = rentalManager.Add(rental);
            Console.WriteLine(result.Message);

        }

       

        //private static void ResultTest(CarManager carManager)
        //{
        //    var result = carManager.GetCarDetails();
        //    if (result.Success)
        //    {
        //        foreach (var car in result.Data)
        //        {
        //            Console.WriteLine(car.CarId + "/" + car.Description + "/" + car.ColorName + "/" + car.BrandName);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //}

        //private static void GetCarDetailsTest(CarManager carManager)
        //{
        //    foreach (var car in carManager.GetCarDetails())
        //    {
        //        Console.WriteLine(car.CarId + "/" + car.Description + "/" + car.ColorName + "/" + car.BrandName);
        //    }
        //}

        //private static void GetById(CarManager carManager)
        //{
        //    var car = carManager.GetById(4);
        //    Console.WriteLine(car.Description);
        //}

        //private static void CarDeleteTest(CarManager carManager)
        //{
        //    Car car = new Car()
        //    {
        //        CarId = 6,
        //        BrandId = 6,
        //        ColorId = 6,
        //        ModelYear = 2000,
        //        DailyPrice = 10,
        //        Description = "eyy"
        //    };
        //    carManager.Delete(car);
        //}

        //private static void CarAddTest(CarManager carManager)
        //{
        //    Car car = new Car
        //    {
        //        CarId = 8,
        //        BrandId = 1,
        //        ColorId = 1,
        //        ModelYear = 2020,
        //        DailyPrice = 5,
        //        Description = "BMW 320i First Edition"
        //    };
        //    carManager.Add(car);
        //}

        //private static void GetAllTest(CarManager carManager)
        //{
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.Description);
        //    }
        //}

        //private static void UpdateTest(CarManager carManager)
        //{
        //    var car = carManager.GetAll().Where(x => x.CarId == 5).FirstOrDefault();
        //    car.Description = "kadir";
        //    carManager.Update(car);
        //}
    }
}

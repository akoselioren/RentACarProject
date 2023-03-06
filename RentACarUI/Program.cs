using Business.Concrete;
using Core.Utilities.Results.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace RentACarUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //BrandTest();
            //ColorTest();
            //CarTest();
            //RentalTest();
           Test();
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            // brandManager.Add(new Brand { BrandName = "Hyundai" });
            // brandManager.Delete(new Brand { Id = 4, BrandName = "Hyundai" });
            // brandManager.Update(new Brand { Id = 2, BrandName = "Volswagen" });

            //foreach (var brand in brandManager.GetById(2).Data)
            //{
            //    Console.WriteLine(brand.BrandName);
            //}

            var result = brandManager.GetAll();

            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            // colorManager.Add(new Color { ColorName = "Sarı" });
            // colorManager.Delete(new Color { Id = 4, ColorName = "Sarı" });
            // colorManager.Update(new Color { Id = 2, ColorName = "Turuncu" });

            //foreach (var color in colorManager.GetById(1).Data)
            //{
            //    Console.WriteLine(color.ColorName);
            //}

            var result = colorManager.GetAll();

            if (result.Success)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            // carManager.Add(new Car { BrandId = 1, ColorId = 3, ModelYear = 2022, DailyPrice = 625, Description = "Audi-A5-Dizel" });
            // carManager.Delete(new Car { Id = 19 });
            // carManager.Update(new Car { Id = 20, BrandId = 1, ColorId = 3, ModelYear = 2020, DailyPrice = 525, Description = "Audi-A3-Benzin" });

            //foreach (var car in carManager.GetById(20).Data)
            //{
            //    Console.WriteLine(car.Description);
            //}

            var result=carManager.GetAll();

            if (result.Success) 
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental { CarId=2,CustomerId=1,RentDate= new DateTime(2023, 03, 03), ReturnDate = new DateTime(2023, 03, 05) });
            var result= rentalManager.GetAll();

            if (result.Success)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.CarId + " || " + rental.CustomerId + " || " + rental.RentDate + " || " + rental.ReturnDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }
        private static void Test()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.ModelName + " || " + car.BrandName + " || " + car.ColorName + " || " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }

    }
}

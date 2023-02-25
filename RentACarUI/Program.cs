using Business.Concrete;
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
            //BrandCRUDTest();
            //ColorCRUDTest();
            //CarCRUDTest();
            CarTest();
        }

        private static void BrandCRUDTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Hyundai" });
            brandManager.Delete(new Brand { Id = 4, BrandName = "Hyundai" });
            brandManager.Update(new Brand { Id = 2, BrandName = "Volswagen" });
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }

            foreach (var brand in brandManager.GetById(2))
            {
                Console.WriteLine(brand.BrandName);
            }
        }
        private static void ColorCRUDTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "Sarı" });
            colorManager.Delete(new Color { Id = 4, ColorName = "Sarı" });
            colorManager.Update(new Color { Id = 2, ColorName = "Turuncu" });
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
            foreach (var color in colorManager.GetById(1))
            {
                Console.WriteLine(color.ColorName);
            }
        }
        private static void CarCRUDTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 1, ColorId = 3, ModelYear = 2022, DailyPrice = 625, Description = "Audi-A5-Dizel" });
            carManager.Delete(new Car { Id = 19 });
            carManager.Update(new Car { Id = 20, BrandId = 1, ColorId = 3, ModelYear = 2020, DailyPrice = 525, Description = "Audi-A3-Benzin" });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            foreach (var car in carManager.GetById(20))
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + " || " + car.BrandName + " || " + car.ColorName + " || " + car.DailyPrice);
            }
        }

    }
}

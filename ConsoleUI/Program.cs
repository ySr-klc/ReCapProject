﻿using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using Entities;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
     class Program //Users kısmında eksiklerim var kusura bakmayın ;)
    {
        static void Main(string[] args)
        {
          




            //RentalAddTest();
            //CarTest();
            //BrandTest();
            //ColorTest();
            //CarDtoTest();
            //InvalidNameTest();
        }

        private static void RentalAddTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.Update(new Rental { Id = 1, CarId = 2, CustomerId = 1, ReturnDate = new DateTime(2019, 12, 06) });
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void InvalidNameTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.Add(new Brand { BrandName = "Jeep" });
            if (result.Success)
            {
                
                
                    Console.WriteLine(result.Message);
                
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarDtoTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());


            foreach (var car in carManager.GetCarDetailDtos().Data)
            {
                Console.WriteLine(car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "White" });

            colorManager.Delete(new Color { });//ColorId=?

            colorManager.Update(new Color { ColorId = 1, ColorName = "RED" });

            colorManager.GetById(1);

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Skoda" });
            brandManager.Delete(new Brand { });//BrandId=?
            brandManager.Update(new Brand { BrandId = 1, BrandName = "Bmw" });
            brandManager.GetById(1);

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { ColorId = 1, BrandId = 1, DailyPrice = 2220, ModelYear = 2015, Description = "Bmw kırmızı 520d günlük ücret 220 model 2015" });


            carManager.Update(new Car { CarId = 2, ColorId = 1, BrandId = 1, DailyPrice = 1000, ModelYear = 2000, Description = "Bmw kırmızı z4 günlük ücret 1000 model 2000" });

            carManager.Delete(new Car { });//CarId=?

            carManager.GetByBrandId(1);

            carManager.GetByColorId(1);
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }
        }
    }   
}

using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
     class Program //Arkadaşlar kusura bakmayın projede dictionary kısmı eksik,yetiştiremedim.Yapısal olarak çalışmaktadır.  İlerleyen zamanlarda bitirmeyi düşünüyorum.
    {
        static void Main(string[] args)
        {


            CarManager carManager = new CarManager(new EfCarDal());
            
            foreach  (var car in carManager.GetByBrandId(1))
            {
                Console.WriteLine(car.Description );
            }
        }
    }   
}

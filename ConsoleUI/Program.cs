using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
     class Program //Arkadaşlar kusura bakmayın projede dictionary kısmı eksik,yetiştiremedim.Yapısal olarak çalışmaktadır.  İlerleyen zamanlarda bitirmeyi düşünüyorum.
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach  (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId );
            }
        }
    }   
}

using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal {//: ICarDal
    //{
    //    List<Car> _cars;

    //    public InMemoryCarDal()
    //    {
    //        _cars = new List<Car>
    //        {
    //            new Car { BrandId = 1, ColorId = 1, DailyPrice = 800, ModelYear =2019, CarId = 1, Description = "BMW X3 günlük ücreti 800" }

    //        };

    //    }


    //    public void Add(Car car)
    //    {
    //        _cars.Add(car);
    //    }

    //    public void Delete(Car car)
    //    {
    //        Car carToDelete = _cars.FirstOrDefault(c => c.CarId == car.CarId);
    //        _cars.Remove(carToDelete);

    //    }

    //    public Car Get(Expression<Func<Car, bool>> filter)
    //    {
    //        throw new NotImplementedException();
    //    }



    //    public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
    //    {
    //        return _cars;
    //    }



    //    public void Update(Car car)
    //    {
    //        Car carToUpdate = _cars.FirstOrDefault(c => c.CarId == car.CarId);
    //        carToUpdate.BrandId = car.BrandId;
    //        carToUpdate.CarId = car.CarId;
    //        carToUpdate.ColorId = car.ColorId;
    //        carToUpdate.DailyPrice = car.DailyPrice;
    //        carToUpdate.Description = car.Description;


    //    }


    }
}

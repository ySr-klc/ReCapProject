using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        ICarDal _CarDal;

        public CarManager(ICarDal inMemoryCarDal)
        {
            _CarDal = inMemoryCarDal;

           
        }

        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }
    }
}

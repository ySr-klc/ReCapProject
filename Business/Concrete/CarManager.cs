using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager :   ICarService
    {

        ICarDal _CarDal;
        
 public CarManager(ICarDal inMemoryCarDal)
        {
            _CarDal = inMemoryCarDal;

           
        }

        public List<Car> Add()
        {
            return _CarDal.Add(p => p.DailyPrice > 1);
        }

        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }

        public List<Car> GetByBrandId(int id)
        {
            return _CarDal.GetAll(p=>p.BrandId==id);
            
        }

        public List<Car> GetByColorId(int id)
        {
            return _CarDal.GetAll(p=> p.ColorId == id);
        }

        


       
    
    }
}

using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using Entities.DTOs;
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

        public void Add(Car car)
        {
            _CarDal.Add(car);
        }

        public void Delete(Car car)
        {
            _CarDal.Delete(car);
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

        public List<CarDetailDto> GetCarDetailDtos()
        {
            return _CarDal.GetCarDetailDtos();
        }

        public void Update(Car car)
        {
            _CarDal.Update(car);
        }
    }
}

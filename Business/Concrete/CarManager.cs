using Business.Abstract;
using Business.Contants;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {
            _CarDal.Add(car);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Car car)
        {
            _CarDal.Delete(car);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_CarDal.GetAll(),Messages.Listed);
            
        }

        public IDataResult<List<Car>> GetByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_CarDal.GetAll(p=>p.BrandId==id),Messages.Listed);
            
        }

        public IDataResult<List<Car>> GetByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_CarDal.GetAll(p=> p.ColorId == id),Messages.Listed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailDtos()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_CarDal.GetCarDetailDtos(),Messages.Listed);
        }

        public IResult Update(Car car)
        {
            _CarDal.Update(car);
            return new SuccessResult(Messages.Updated);
        }
    }
}

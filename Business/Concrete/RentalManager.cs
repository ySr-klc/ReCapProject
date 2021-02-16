using Business.Abstract;
using Business.Contants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rental)
        {
            _rentalDal = rental;
        }
        public IResult Add(Rental rental)
        {

            var result = _rentalDal.GetAll(z => z.CarId == rental.CarId && z.ReturnDate == new DateTime(0001,01,01));
            if (result.Count > 0)
            {
              
                return new ErrorResult(Messages.Error);

            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.Added);

        }

       

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.Listed);
        }

        public IDataResult<List<Rental>> GetById(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p=>p.Id==id),Messages.Listed);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
    }
}

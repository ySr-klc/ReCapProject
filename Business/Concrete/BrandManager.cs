﻿using Business.Abstract;
using Business.Contants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
        

            ValidationTool.Validate(new BrandValidator(), brand);
            
            _brandDal.Add(brand);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
                return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),Messages.Listed);
        }

        public IDataResult<List<Brand>> GetById(int id)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(p=> p.BrandId == id), Messages.Listed);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);

            return new SuccessResult(Messages.Updated);
        }
    }
}

﻿using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        List<Car> GetByBrandId(int id);
        
        List<Car> GetByColorId(int id);

        List<Car> Add();
         
    }
}

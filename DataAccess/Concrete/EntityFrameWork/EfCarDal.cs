using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork;
using Entities;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfCarDal : EfEntityRepositoryBase<Car, DatabaseForReCapProject>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos()
        {
            using (DatabaseForReCapProject context =new DatabaseForReCapProject())
            {
                var result = from p in context.Cars
                               join b in context.Brands
                             on p.BrandId equals b.BrandId 
                              
                              join c in context.Colors
                             on p.ColorId equals c.ColorId
                           select  new CarDetailDto{ BrandName = b.BrandName, DailyPrice = p.DailyPrice,ColorName= c.ColorName };
                return result.ToList();
            }
        }
    }
}

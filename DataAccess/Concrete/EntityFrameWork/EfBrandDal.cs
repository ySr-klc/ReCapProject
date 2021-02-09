using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (DatabaseForReCapProject context = new DatabaseForReCapProject())
            {
                entity.BrandName.Substring(2, 255);
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(Brand entity)
        {
            
            using (DatabaseForReCapProject context = new DatabaseForReCapProject())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (DatabaseForReCapProject context = new DatabaseForReCapProject())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (DatabaseForReCapProject context = new DatabaseForReCapProject())
            {
                return filter == null
                    ? context.Set<Brand>().ToList()
                    : context.Set<Brand>().Where(filter).ToList();
            }
        }

        public void Update(Brand entity)
        {
            using (DatabaseForReCapProject context = new DatabaseForReCapProject())
            {
                var UpdatedEntity = context.Entry(entity);
                UpdatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}

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
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            
            using (DatabaseForReCapProject context = new DatabaseForReCapProject())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

        }
            }

        public void Delete(Color entity)
        {
            using (DatabaseForReCapProject context = new DatabaseForReCapProject())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (DatabaseForReCapProject context = new DatabaseForReCapProject())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (DatabaseForReCapProject context = new DatabaseForReCapProject())
            {
                return filter == null
                    ? context.Set<Color>().ToList()
                    : context.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color entity)
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

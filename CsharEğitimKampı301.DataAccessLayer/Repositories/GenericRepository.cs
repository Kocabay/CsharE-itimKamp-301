using CsharEğitimKampı301.DataAccessLayer.Abstract;
using CsharEğitimKampı301.DataAccessLayer.Context;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CsharEğitimKampı301.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        KampContext context = new KampContext();
        private readonly DbSet<T> _object;
        public GenericRepository()
        {
            _object = context.Set<T>();
        }

        public void Delete(T entity)
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();

        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T entity)
        {
            var addEntity = context.Entry(entity);
            addEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var updateEntity = context.Entry(entity);
            updateEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}

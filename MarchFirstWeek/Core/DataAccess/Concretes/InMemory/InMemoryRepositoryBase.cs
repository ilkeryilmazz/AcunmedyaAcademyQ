using Core.DataAccess.Abstracts;
using Core.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Concretes.InMemory
{
    public class InMemoryRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity :  BaseEntity
    {

        private readonly List<TEntity> _entities;
        public InMemoryRepositoryBase()
        {
            _entities = new List<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _entities.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            TEntity existingEntity = _entities.FirstOrDefault(e => e.Id == entity.Id);
            _entities.Remove(existingEntity);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            TEntity data = _entities.AsQueryable().Where(filter).FirstOrDefault();
            return data;
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            List<TEntity> data = filter == null ? _entities : _entities.AsQueryable().Where(filter).ToList();
            return data;
        }

        public void Update(TEntity entity)
        {
            TEntity existingEntity = _entities.FirstOrDefault(e => e.Id == entity.Id);
            if (existingEntity != null)
            {
                _entities.Remove(existingEntity);
                _entities.Add(entity);
            }

        }
    }
}

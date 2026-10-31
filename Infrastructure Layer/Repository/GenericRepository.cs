using Domain_Layer.Common;
using Domain_Layer.Entities.Drivers;
using Domain_Layer.Repository;
using Infrastructure_Layer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.Repository
{
    internal class GenericRepository<TEntity>(AppDbContext appDbContext) : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly AppDbContext appDbContext = appDbContext;

        public Task<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetById()
        {
            throw new NotImplementedException();
        }

        public void Add(TEntity entity)
            => appDbContext.Set<TEntity>().Add(entity);


        public void Delete(TEntity entity)
            => appDbContext.Set<TEntity>().Remove(entity);

        public void Update(TEntity entity)
        => appDbContext.Set<TEntity>().Update(entity);
    }
}

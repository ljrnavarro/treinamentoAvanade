﻿using Avanade.SubTCSE.Data.Repositories.Base.MongoDB;
using Avanade.SubTCSE.Projeto.Domain.Aggregates;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository.MongoDB;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Data.Repositories.Base
{
    public abstract class BaseRepository<TEntity, Tid>
        : IBaseRepository<TEntity, Tid> where TEntity : BaseEntity<Tid>

    {
        private readonly IMongoCollection<TEntity> _collection;

        protected BaseRepository(IMongoDBContext mongoDBContext, string collectionName)
        {
            _collection = mongoDBContext.GetCollection<TEntity>(collectionName);
        }

        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            await _collection.InsertOneAsync(entity);
            return entity;
        }

        public virtual async Task<TEntity> FindByIdAsync(Tid Id)
        {
            throw new System.NotImplementedException();
        }
    }
}

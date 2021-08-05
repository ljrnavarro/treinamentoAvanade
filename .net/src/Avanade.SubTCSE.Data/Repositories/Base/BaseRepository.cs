using Avanade.SubTCSE.Data.Repositories.Base.MongoDB;
using Avanade.SubTCSE.Projeto.Domain.Aggregates;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository.MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
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

        public async Task<List<TEntity>> FindAllAsync()
        {
            var all = await _collection.FindAsync(new BsonDocument());

            return await all.ToListAsync();
        }

        public virtual async Task<TEntity> FindByIdAsync(Tid Id)
        {
            var filter = Builders<TEntity>.Filter.Eq("_id", Id);

            var resultado = await _collection.FindAsync(filter);

            return resultado.FirstOrDefault();
        }

        public virtual async Task<TEntity> DeleteByIdAsync(Tid Id)
        {
            var roleDelete = await this.FindByIdAsync(Id);
            
            var filter = Builders<TEntity>.Filter.Eq("_id", Id);

            var resultado = await _collection.DeleteOneAsync(filter);

            if (resultado.IsAcknowledged)
                return roleDelete;
            else
                return null;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var roleName = entity.ToBsonDocument().GetValue("rolename").ToString();

            var guiId = entity.ToBsonDocument().GetValue("_id").ToString();

            //Guid guidId = Guid.Parse(guiId);

            var roleUpdate = Builders<TEntity>.Filter.Eq("_id", guiId);

            var update = Builders<TEntity>.Update.Set("rolename", roleName);

            var resultado = _collection.UpdateOneAsync(roleUpdate, update);

            if (resultado.IsCompleted)
                return await this.FindByIdAsync(entity.Id);
            else
                return null;
        }
    }
}

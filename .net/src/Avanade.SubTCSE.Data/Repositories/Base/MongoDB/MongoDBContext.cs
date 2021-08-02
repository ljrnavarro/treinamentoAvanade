using Avanade.SubTCSE.Projeto.Domain.Base.Repository.MongoDB;
using MongoDB.Driver;
using System;
using System.Security;
using System.Security.Authentication;

namespace Avanade.SubTCSE.Data.Repositories.Base.MongoDB
{
    public class MongoDBContext : IMongoDBContext
    {
        private readonly IMongoDatabase _mongoDatabase;

        public MongoDBContext()
        {
            string connectionString =
            "mongodb://root:Abcd1234@127.0.0.1:27017/admin?authSource=admin";
            
            MongoClientSettings settings = MongoClientSettings.FromUrl(
              new MongoUrl(connectionString)
            );

            settings.SslSettings = new SslSettings() { 
               EnabledSslProtocols = SslProtocols.Tls12
            };

            var mongoClient = new MongoClient(settings);
            _mongoDatabase = mongoClient.GetDatabase("fullstack");
      
        }

        public IMongoCollection<TEntity> GetCollection<TEntity>(string collection)
        {
            return _mongoDatabase.GetCollection<TEntity>(name: collection);
        }
    }
}

using Avanade.SubTCSE.Projeto.Domain.Base.Repository.MongoDB;
using MongoDB.Driver;
using System.Security.Authentication;

namespace Avanade.SubTCSE.Data.Repositories.Base.MongoDB
{
    public class MongoDBContext : IMongoDBContext
    {
        private readonly IMongoDatabase _mongoDatabase;

        public MongoDBContext()
        {
            string connectionString =
            "mongodb://root:Abcd1234@127.0.0.1:27017/?connect=direct&ssl=true";
             //@"mongodb://mongoaccnt:ADASDXZWADAS2VgsqTYcTS4gtADmB1zQ==@mongocnt.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";

            MongoClientSettings settings = MongoClientSettings.FromUrl(
              new MongoUrl(connectionString)
            );

           // settings.ConnectTimeout = System.TimeSpan.FromMinutes(5);

            settings.SslSettings = new SslSettings() { 
               EnabledSslProtocols = SslProtocols.Tls12
            };

            var mongoClient = new MongoClient(settings);
            _mongoDatabase = mongoClient.GetDatabase("fullstack");
             /*//  string collectionName = "test";
            //  var database = mongoClient.GetDatabase(dbName);


            //  var todoTaskCollection = database.GetCollection<test>(collectionName);


              var mongoClientSettings = new MongoClientSettings()
            {
                Server = new MongoServerAddress("127.0.0.1", 27017),
                Credential = MongoCredential.CreateCredential("fullstack", "root", "Abcd12345"),
                UseTls = true,
                DirectConnection = false,
                ReplicaSetName = "globaldb",
                SslSettings = new SslSettings()
                {
                    EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12
                }
            };

            MongoClient mongoClient = new MongoClient(settings: mongoClientSettings);
            _mongoDatabase = mongoClient.GetDatabase("fullstack");

         MongoClientSettings mongoClientSettings = MongoClientSettings
             .FromUrl(new MongoUrl("mongodb://root:Abcd1234@localhost:27017?ssl=true"));

         mongoClientSettings.SslSettings =
               new SslSettings()
             {
                  EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12
              };

          MongoClient mongoClient = new MongoClient(settings: mongoClientSettings);

            _mongoDatabase = mongoClient.GetDatabase("fullstack");*/
        }

        public IMongoCollection<TEntity> GetCollection<TEntity>(string collection)
        {
            return _mongoDatabase.GetCollection<TEntity>(name: collection);
        }
    }
}

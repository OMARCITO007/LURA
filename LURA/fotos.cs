using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace LURA
{


    public class MongoDBHelper
    {
        private readonly IMongoCollection<BsonDocument> _fotosCollection;


        public MongoDBHelper()
        //public MongoDBHelper(string connectionString, string databaseName, string collectionName)
        {
            //var client = new MongoClient(connectionString);
            //var database = client.GetDatabase(databaseName);
            //_fotosCollection = database.GetCollection<BsonDocument>(collectionName);
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("lura");
            _fotosCollection = database.GetCollection<BsonDocument>("fotos");
        }

        public List<Foto> GetFotos()
        {
            var fotosBson = _fotosCollection.Find(new BsonDocument()).ToList();
            return fotosBson.Select(bson => new Foto
            {
                Id = bson["_id"].AsObjectId.ToString(),
                Fecha = bson["fecha"].ToUniversalTime(),
                Latitud = bson["latitud"].AsString,
                Longitud = bson["longitud"].AsString,
                Distancia = bson["distancia"].AsString,
                NombreArchivo = bson["nombre_archivo"].AsString
            }).ToList();
        }
    }

    public class Foto
    {
        public string Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Distancia { get; set; }
        public string NombreArchivo { get; set; }
    }
}

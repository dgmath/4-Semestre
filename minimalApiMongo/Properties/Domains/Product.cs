using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace minimalApiMongo.Properties.Domains
{
    public class Product
    {
        //identificar como id do tipo bson
        [BsonId]
        //apelidar e colocar para ser auto-incrementado como um objectId
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("price")]
        public decimal Price { get; set; }

        //Adicionar um dicionario para ter quantos atributos for necessario
        public Dictionary<string, string> AdditionalAttributes { get; set; }

        public Product()
        {
            AdditionalAttributes = new Dictionary<string, string>();
        }
    }
}

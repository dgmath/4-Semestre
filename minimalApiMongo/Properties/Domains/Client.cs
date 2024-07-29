using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace minimalApiMongo.Properties.Domains
{
    public class Client
    {
        //identificar como id do tipo bson
        [BsonId]
        //apelidar e colocar para ser auto-incrementado como um objectId
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        //apelidar e colocar para ser auto-incrementado como um objectId
        [BsonElement("userId"), BsonRepresentation(BsonType.ObjectId)]
        public string? UserId { get; set;}

        [BsonElement]
        public string? Cpf { get; set; }

        [BsonElement]
        public string? Phone { get; set; }

        [BsonElement]
        public string? Address { get; set; }

        public Dictionary<string, string> AdditionalAttributes { get; set; }

        public Client()
        {
            AdditionalAttributes = new Dictionary<string, string>();
        }
    }
}

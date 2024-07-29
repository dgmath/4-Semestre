using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace minimalApiMongo.Properties.Domains
{
    public class User
    {
        //identificar como id do tipo bson
        [BsonId]
        //apelidar e colocar para ser auto-incrementado como um objectId
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("email")]
        public string? Email { get; set; }

        [BsonElement("password")] 
        public string? Password { get; set; }

        public Dictionary<string, string> AdditionalAttributes { get; set; }

        public User()
        {
            AdditionalAttributes = new Dictionary<string, string>();
        }

    }
}

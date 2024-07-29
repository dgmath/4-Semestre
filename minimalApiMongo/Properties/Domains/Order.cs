using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace minimalApiMongo.Properties.Domains
{
    public class Order
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement]
        public DateOnly? Date { get; set; }

        [BsonElement]
        public string? Status { get; set; }

        [BsonElement("clientId"), BsonRepresentation(BsonType.ObjectId)]
        public string? ClientId { get; set; }

        [BsonElement("product"), BsonRepresentation(BsonType.ObjectId)]
        public List<string>? ProductsId { get; set; }

        public class OrderResponse
        {
            public Order Order { get; set; }
            public Client Client { get; set; }
            public List<Product> Products { get; set; }
        }
    }
}

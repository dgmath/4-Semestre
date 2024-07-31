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

        // referencia dos produtos

        [BsonElement("ProductId")]
        public List<string>? ProductId { get; set; }

        public List<Product>? Products { get; set; }


        // referencia do cliente

        [BsonElement("ClientId")]
        public string? ClientId { get; set; }

        public Client? Client { get; set; }

    }
}

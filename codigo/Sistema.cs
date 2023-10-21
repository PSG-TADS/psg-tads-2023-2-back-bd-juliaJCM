using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Sistema_Mongo.Models
{
    public class Sistema
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("Nome")]
        public string? Nome { get; set; } = null!;
        public string? Email { get; set; } = null!;
        public int Senha { get; set; }
        public int CPF { get; set; }
    }
}

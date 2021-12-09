using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;


namespace Books.Common
{
    public abstract class Document : IDocument
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
    }
}

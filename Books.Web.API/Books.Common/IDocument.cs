using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;


namespace Books.Common
{
    public interface IDocument
    {
       
        string Id { get; set; }
    }
}

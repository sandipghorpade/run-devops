﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Shopping.API.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; } = default!;

        public string Category { get; set; } = default!;

        public string Description { get; set; } = default!;

        public string ImageFile { get; set; } = default!;

        public decimal Price { get; set; }
    }
}

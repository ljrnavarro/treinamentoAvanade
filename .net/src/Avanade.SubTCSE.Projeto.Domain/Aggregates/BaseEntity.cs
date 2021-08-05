using FluentValidation.Results;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates
{
    public record BaseEntity<Tid>
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))] 
        public Tid Id { get; set; }

        [BsonIgnore]
        public ValidationResult validationResult {get; set;}
    }
}

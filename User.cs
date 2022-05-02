using System;
using SuvillianceSystem.Connections.Infrastructure;
using SuvillianceSystem.Connections.Concrete;

namespace SuvillianceSystem.Models
{
    [BsonCollectionAttribute("Users")]
    public class User : IIdentifiable
    {
        public string Id { get ; set ; }
        public string Email { get; set; }
        public string UserName { get; set; }
    }
}

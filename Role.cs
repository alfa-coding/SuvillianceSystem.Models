using System;
using SuvillianceSystem.Connections.Concrete;
using SuvillianceSystem.Connections.Infrastructure;
using SuvillianceSystem.Models.PublicEnums;

namespace SuvillianceSystem.Models
{
    [BsonCollectionAttribute("Roles")]
    public class Role : IIdentifiable
    {
        public string Id { get; set; }

        public string RoleGivenName { get; set; }

    }
}

using System;
using SuvillianceSystem.Connections.Infrastructure;
using SuvillianceSystem.Connections.Concrete;
using System.Collections.Generic;
using SuvillianceSystem.Models.SupportClasses;

namespace SuvillianceSystem.Models.One2Many
{
    [BsonCollectionAttribute("UserRoles")]
    public class UserRole : IIdentifiable
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public List<Role> ExistingRoles { get; set; }
    }
}
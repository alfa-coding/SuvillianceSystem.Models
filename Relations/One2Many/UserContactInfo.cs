using System;
using SuvillianceSystem.Connections.Infrastructure;
using SuvillianceSystem.Connections.Concrete;
using System.Collections.Generic;
using SuvillianceSystem.Models.SupportClasses;

namespace SuvillianceSystem.Models.One2Many
{
    [BsonCollectionAttribute("UserContactInfo")]
    public class UserContactInfo : IIdentifiable
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public List<ContactInfo> UserContacs { get; set; }
    }
}
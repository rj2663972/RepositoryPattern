using RP.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RP.Domain.Entities.UserAgg
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}

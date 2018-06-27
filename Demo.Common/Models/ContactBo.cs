using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Common.Models
{
    public class ContactBo:IEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
    
    }
}

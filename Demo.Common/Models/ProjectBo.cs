using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Common.Models
{
   public class ProjectBo:IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
        //public ICollection<Contact> Contacts { get; set; }
    }
}

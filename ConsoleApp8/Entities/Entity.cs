using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Entities
{
    public class Entity
    {
        public int IdEntity { get; set; }
        public int IdChannel { get; set; }
        public ICollection<Property> Properties { get; set; }
    }
}

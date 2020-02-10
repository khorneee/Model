using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;   

namespace ConsoleApp8.Entities
{
    public class Property
    {
        public int IdProperty { get; set; }
        public int IdEntity { get; set; }
        public Entity Entity { get; set; }
        public string Title { get; set; }
        public ICollection<PropertyValues> Values { get; set; }
    }
}

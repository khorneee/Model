using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Entities
{
    public class Component
    {
        public int IdComponent { get; set; }
        public string Type { get; set; }
        public string Format { get; set; }
        public ICollection<ComponentPropertiesContainer> ComponentProperties { get; set; }
    }
}

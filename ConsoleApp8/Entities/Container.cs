using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Entities
{
    public class Container
    {
        public int IdContainer { get; set; }
        public int IdChannel { get; set; }
        public string Title { get; set; }
        public ICollection<ComponentPropertiesContainer> ComponentProperties { get; set; }
    }
}

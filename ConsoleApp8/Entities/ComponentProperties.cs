using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Entities
{
    public class ComponentPropertiesContainer
    {
        public int IdContainer { get; set; }
        public Container Container { get; set; }
        public int IdComponent { get; set; }
        public Component Component { get; set; }
        public int IdProperty { get; set; }
        public Property Property { get; set; }
    }
}

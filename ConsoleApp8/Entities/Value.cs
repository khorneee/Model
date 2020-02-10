using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Entities
{
    public class PropertyValues
    {
        public int IdValue { get; set; }
        public int IdUnderlyingCause { get; set; }
        public int IdProperty { get; set; }
        public string Value { get; set; }
        public Property Property { get; set; }
    }
}

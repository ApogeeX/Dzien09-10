using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalLibrary
{
    public class SomeClass
    {
        public string SomeProperty { get; set; }
        public int SomeIntProperty { get; set; }

        public int Field = 3;

        public SomeClass() 
        {
            SomeProperty = "ABCDEF"; SomeIntProperty = 1;
        }

        public SomeClass(string s)
        {
            SomeProperty = s;
        }

        public int AddFieldToProperty()
        {
            return Field + SomeIntProperty;
        }
    }
}

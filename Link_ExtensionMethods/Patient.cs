using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link_ExtensionMethods
{
    internal class Patient
    {
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public int Age { get; set; }
        public int Costs { get; set; }

        public override string ToString()
        {
            return $"{Firstname} {Lastname} {Age} {Costs}";
        }
    }
}

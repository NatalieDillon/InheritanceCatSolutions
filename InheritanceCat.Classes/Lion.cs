using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCat.Classes
{
    public class Lion: Cat
    {
        public Lion() : base("wild", 1100)
        {
        }

        public override string Eat()
        {
            return "Roar!!!!";
        }
    }
}

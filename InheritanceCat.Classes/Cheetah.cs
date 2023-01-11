using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCat.Classes
{
    public class Cheetah : Cat
    {
        public Cheetah() : base("wild", 80)
        {
        }
        public override string Eat()
        {
            return "Zzzzzz";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCat.Classes
{
    public class DomesticCat : Cat
    {
        public DomesticCat(): base("domestic", 23)
        {
        }

        public override string Eat()
        {
            return "Purrrrrrr";
        }
    }
}

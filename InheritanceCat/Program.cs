using InheritanceCat.Classes;

namespace InheritanceCat
{
    internal class Program
    {
        static void Main()
        {
            DomesticCat cat = new DomesticCat();
            Console.WriteLine(cat.Eat());
        }
    }
}
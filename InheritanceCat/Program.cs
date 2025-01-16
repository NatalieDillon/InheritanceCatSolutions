using InheritanceCat.Classes;

namespace InheritanceCat
{
    internal class Program
    {
        static void Main()
        {
            DomesticCat cat = new();
            Console.WriteLine(cat.Eat());
        }
    }
}
using System;

namespace CSharpClone
{
    class Program
    {
        static void Main(string[] args)
        {
            Rock rock1 = new Rock(10, true, false);
            Rock rock2 = rock1.Clone() as Rock;

            Console.WriteLine("1. {0}", rock1);
            Console.WriteLine("2. {0}", rock2);

            Person emily = new Person();
            emily.FirstName = "Emily";
            emily.LastName = "Bronte";
            emily.PersonAddress.HouseNumber = 100;
            emily.PersonAddress.StreetName = "Test Street, Karnataka, India";

            Person emilyClone1 = (Person)emily.Clone();
            emilyClone1.PersonAddress.HouseNumber = 500;

            Console.WriteLine("\n**************************************");
            Console.WriteLine("Emily House Number. {0}", 
                emily.PersonAddress.HouseNumber);
            Console.WriteLine("Emily Clone House Number. {0}",
                emilyClone1.PersonAddress.HouseNumber);
            Console.WriteLine("**************************************");

            Person emilyClone2 = emilyClone1.DeepClone();
            emilyClone2.PersonAddress.HouseNumber = 600;

            Console.WriteLine("\n**************************************");
            Console.WriteLine("Emily House Number. {0}",
               emily.PersonAddress.HouseNumber);
            Console.WriteLine("Emily Clone 1 House Number. {0}",
                emilyClone1.PersonAddress.HouseNumber);
            Console.WriteLine("Emily Clone 2 House Number. {0}",
               emilyClone2.PersonAddress.HouseNumber);
            Console.WriteLine("**************************************");

            Console.ReadLine();
        }
    }
}

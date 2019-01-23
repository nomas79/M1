using System;

namespace M1.Scrap
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new TestClass { firstname = "mas", lastname = "ben" };

            Console.WriteLine(name.GetIntroduction());
            Console.ReadLine();

        }
    }
}

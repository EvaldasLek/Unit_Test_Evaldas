using NUnit.Framework;
using System;

namespace Uzduotis_17
{
    public class Tests
    {
        [Test]
        public void Test()
        {
            int number = 995;
            bool rezultatas = number % 3 == 0;

            Assert.IsTrue(rezultatas);

            if (number % 3 == 0)

            {
                Console.WriteLine($"{number} dalijasi is 3 be liekanos.");
            }

            else 
            {
                Console.WriteLine($"{number} nesidalija is 3 be liekanos.");
            }

        }
 
    }
}

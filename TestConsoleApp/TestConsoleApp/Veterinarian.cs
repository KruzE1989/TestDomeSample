using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDomeSolutions
{
    public class Veterinarian
    {
        Queue<string> pets = new Queue<string>();

        public void Accept(string petName)
        {
            pets.Enqueue(petName);
        }

        public string Heal()
        {
            if (pets.Count > 0)
            {
                return pets.Dequeue();
            }
            return null;

        }

        public static void Main(string[] args)
        {
            Veterinarian veterinarian = new Veterinarian();
            veterinarian.Accept("Barkley");
            veterinarian.Accept("Mittens");
            Console.WriteLine(veterinarian.Heal()); // Should print: Barkley
            Console.WriteLine(veterinarian.Heal()); // Should print: Mittens
        }
    }
}

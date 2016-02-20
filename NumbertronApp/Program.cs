using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbertronApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool success = false;
            uint count;

            do
            {
                Console.WriteLine("Введите кол-во чисел для решения спора");
                success = uint.TryParse(Console.ReadLine(), out count);
            }
            while (success == false);

            Jay jay = new Jay();
            SilentBob bob = new SilentBob();

            Numbertron numbertron = new Numbertron();

            numbertron.NewNumber += jay.FetchNewNumber;
            numbertron.NewNumber += bob.FetchNewNumber;

            for (int i = 0; i < count; i++)
            {
                numbertron.Generate();
            }

            if (jay.Score > bob.Score)
            {
                Console.WriteLine("Победил {0}", jay.Name);
            }
            else if (jay.Score < bob.Score)
            {
                Console.WriteLine("Победил {0}", bob.Name);
            }
            else if (jay.Score == bob.Score)
            {
                Console.WriteLine("DRAW");
            }

            Console.ReadLine();
        }

       
    }
}

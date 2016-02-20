using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbertronApp
{
    public class Numbertron
    {
        //делегат
        public delegate void NewNumberEventHandler(int number);

        public event NewNumberEventHandler NewNumber;

        private Random _rand = new Random();

        public void OnNewNumber(int num)
        {
            NewNumber?.Invoke(num);
        }

        public void Generate()
        {
            int num = _rand.Next();
            Console.WriteLine(num);
            OnNewNumber(num);
        }
    }
}

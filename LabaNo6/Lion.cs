using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaNo6
{
    internal class Lion : IMeowable
    {
        private string Lname;

        public string Name
        {
            get => Lname;
            set => Lname = value;
        }

        public Lion(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Лев: {Name}";
        }

        public void Meow()
        {
            Console.WriteLine($"{Name}: Маау!");
        }

        public void Meow(int N)
        {
            if (N <= 0)
                Console.WriteLine("Невеный ввод числа мяукний льва");
            else
            {
                string meows = string.Join("-", new string[N].Select(_ => "Маау"));
                Console.WriteLine($"{Name}: {meows}!");
            }

        }
    }
}

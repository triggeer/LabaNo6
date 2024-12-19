using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaNo6
{
    internal class Cat : IMeowable
    {
        private string Name;

        public string CName
        {
            get => Name;
            set => Name = value;
        }

        public Cat(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Кот: {Name}";
        }

        public void Meow()
        {
            Console.WriteLine($"{Name}: Мяу!");
        }

        public void Meow(int N)
        {
            if (N <= 0)
                 Console.WriteLine("Невеный ввод числа мяуканьей кота");
            else
            {
                string meows = string.Join("-", new string[N].Select(_ => "мяу"));
                Console.WriteLine($"{Name}: {meows}!");
            }    

        }
    }
}

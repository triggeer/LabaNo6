using System;

namespace LabaNo6
{
    public class Drobi : ICloneable, IDrobable<int>
    {
        // Приватные поля
        private int chislitel; // Числитель
        private int znaminatel; // Знаменатель

        private double? casheZnach; //? после типа означает возможность присваивания null

        // Свойства для доступа
        public int Chislitel 
        {
            get => chislitel;
            set
            {
                chislitel = value;
                casheZnach = null; // Сбрасываем кэш при изменении числителя
            }
 
            
        }
            
        public int Znaminatel
        {
            get => znaminatel;  
            set
            {
                if (value == 0)
                    throw new ArgumentException("Знаменатель не может быть равен нулю.");
                if (value < 0)
                {
                    chislitel = -chislitel; // Делает знаменатель положительным
                    value = -value;
                }
                znaminatel = value;
                casheZnach = null; // Сбрасываем кэш при изменении знаменателя
            }
        }

        // Конструктор
        public Drobi(int chislitel, int znaminatel)
        {
            Chislitel = chislitel;
            Znaminatel = znaminatel;
            Uproshenie(); // Упрощение дроби
        }

        // Упрощение дроби с использованием НОД
        private void Uproshenie()
        {
            int nod = NOD(Math.Abs(chislitel), znaminatel);
            chislitel /= nod;
            znaminatel /= nod;
        }

        // Нахождение НОД по Евклиду
        private static int NOD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }


        public double GetVeshValue()
        {
            // Используем кэширование: если значение уже рассчитано, возвращаем его
            if (casheZnach == null)
            {
                casheZnach = (double)chislitel / znaminatel;
            }
            return casheZnach.Value;
        }


        public void SetChislitZnach(int value1, int value2)
        {
            chislitel = value1;
            if (value2 == 0)
                throw new ArgumentException("Знаменатель не может быть равен нулю.");
            znaminatel = value2;
        }

        public object Clone()
        {
            // Создаём новый объект дроби с такими же значениями числителя и знаменателя
            return new Drobi(this.Chislitel, this.Znaminatel);
        }



        // Перегрузка ToString
        public override string ToString()
        {
            return $"{chislitel}/{znaminatel}";
        }








        // Переопределение Equals для сравнения дробей
        public override bool Equals(object obj)
        {
            if (obj is Drobi other)
            {
                return Equals(other);
            }
            return false;
        }


        public bool Equals(Drobi other)
        {
            if (other == null) return false;
            return Chislitel == other.Chislitel  && Znaminatel == other.Znaminatel;
        }

        // Переопределение оператора ==
        public static bool operator ==(Drobi left, Drobi right)
        {
            if (ReferenceEquals(left, null)) return ReferenceEquals(right, null);
            return left.Equals(right);
        }

        // Переопределение оператора !=
        public static bool operator !=(Drobi left, Drobi right)
        {
            return !(left == right);
        }






        // Операции с дробями
        public Drobi Plus(Drobi other)
        {
            int newChislitel = chislitel * other.znaminatel + other.chislitel * znaminatel;
            int newZnaminatel = znaminatel * other.znaminatel;
            return new Drobi(newChislitel, newZnaminatel);
        }

        public Drobi Minus(Drobi other)
        {
            int newChislitel = chislitel * other.znaminatel - other.chislitel * znaminatel;
            int newZnaminatel = znaminatel * other.znaminatel;
            return new Drobi(newChislitel, newZnaminatel);
        }

        public Drobi Umnozenie(Drobi other)
        {
            int newChislitel = chislitel * other.chislitel;
            int newZnaminatel = znaminatel * other.znaminatel;
            return new Drobi(newChislitel, newZnaminatel);
        }

        public Drobi Delenie(Drobi other)
        {
            if (other.chislitel == 0)
                throw new DivideByZeroException("Нельзя делить на 0.");
            int newChislitel = chislitel * other.znaminatel;
            int newZnaminatel = znaminatel * other.chislitel;
            return new Drobi(newChislitel, newZnaminatel);
        }

        // Операции с целыми числами
        public Drobi Plus(int number)
        {
            return Plus(new Drobi(number, 1));
        }

        public Drobi Minus(int number)
        {
            return Minus(new Drobi(number, 1));
        }

        public Drobi Umnozenie(int number)
        {
            return Umnozenie(new Drobi(number, 1));
        }

        public Drobi Delenie(int number)
        {
            if (number == 0)
                throw new DivideByZeroException("Нельзя делить на 0.");
            return Delenie(new Drobi(number, 1));
        }
    }
}
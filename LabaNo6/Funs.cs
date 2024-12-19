using System;
using System.Collections.Generic;

namespace LabaNo6
{
    internal static class Funs
    { 
        // Метод вызывает Meow() у всех мяукающих объектов и обновляет счётчики.

        public static void MakeAllMeow(List<IMeowable> meowables, Dictionary<IMeowable, int> meowCounters)
        {
            foreach (var obj in meowables)
            {
                obj.Meow();

                // Увеличиваем количество мяуканий в словаре
                if (obj is Cat cat)
                {
                    if (meowCounters.ContainsKey(cat))
                    {
                        meowCounters[cat]++;
                    }
                    else
                    {
                        meowCounters[cat] = 1;
                    }
                }
            }
        }
    }
}
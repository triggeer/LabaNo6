using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaNo6
{
    internal interface IDrobable<T>
    {
        // Получение вещественного значения дроби
        double GetVeshValue();

        // Установка числителя и знаменателя
        void SetChislitZnach(T value1, T value2);
    }
}

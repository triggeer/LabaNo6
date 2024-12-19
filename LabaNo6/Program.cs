using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaNo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IMeowable> meowables = new List<IMeowable>();
            List<Drobi> Drobis = new List<Drobi>();

            // Список оберток MeowCounter для подсчета количества мяуканий
            Dictionary<IMeowable, int> meowCounters = new Dictionary<IMeowable, int>();


            while (true)
            {
                Console.WriteLine("\nВыберите, с какими объектами работать:");
                Console.WriteLine("1. С мяукающими");
                Console.WriteLine("2. С дробями");
                Console.WriteLine("3. Завершить работу");
                string mainChoice = Console.ReadLine();

                switch (mainChoice)
                {
                    case "1": // Работа с мяукающими
                        while (true)
                        {
                            Console.WriteLine("\nВыберите действие с мяукающими:");
                            Console.WriteLine("1. Создать нового кота");
                            Console.WriteLine("2. Создать нового льва");
                            Console.WriteLine("3. Вывести всех мяукающих");
                            Console.WriteLine("4. Пусть один объект мяукнет");
                            Console.WriteLine("5. Пусть объект мяукнет несколько раз");
                            Console.WriteLine("6. Пусть все мяукающие мяукнут один раз");
                            Console.WriteLine("7. Показать количество мяуканий для каждого объекта");
                            Console.WriteLine("8. Завершить работу");
                            Console.Write("Ваш выбор: ");
                            string choice = Console.ReadLine();

                            switch (choice)
                            {
                                case "1": // Создать кота
                                    Console.Write("Введите имя кота: ");
                                    string catName = Console.ReadLine();
                                    meowables.Add(new Cat(catName));
                                    Console.WriteLine($"Кот {catName} создан.");
                                    break;

                                case "2": // Создать льва
                                    Console.Write("Введите имя льва: ");
                                    string lionName = Console.ReadLine();
                                    meowables.Add(new Lion(lionName));
                                    Console.WriteLine($"Лев {lionName} создан.");
                                    break;

                                case "3": // Вывести всех мяукающих
                                    if (meowables.Count == 0)
                                    {
                                        Console.WriteLine("Список мяукающих пуст.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nСписок всех мяукающих:");
                                        for (int i = 0; i < meowables.Count; i++)
                                        {
                                            Console.WriteLine($"{i + 1}. {meowables[i]}");
                                        }
                                    }
                                    break;

                                case "4": // Пусть один объект мяукнет
                                    if (meowables.Count == 0)
                                    {
                                        Console.WriteLine("Список объектов пуст.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nВыберите объект для мяуканья:");
                                        for (int i = 0; i < meowables.Count; i++)
                                        {
                                            Console.WriteLine($"{i + 1}. {meowables[i]}");
                                        }
                                        int index = Proverka.IntNum("Введите номер объекта: ") - 1;

                                        if (index >= 0 && index < meowables.Count)
                                        {
                                            meowables[index].Meow();
                                            
                                        }
                                        else
                                        {
                                            Console.WriteLine("Неверный номер объекта.");
                                        }
                                    }
                                    break;

                                case "5": // Пусть объект мяукнет несколько раз
                                    if (meowables.Count == 0)
                                    {
                                        Console.WriteLine("Список объектов пуст.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nВыберите объект для многократного мяуканья:");
                                        for (int i = 0; i < meowables.Count; i++)
                                        {
                                            Console.WriteLine($"{i + 1}. {meowables[i]}");
                                        }
                                        int index = Proverka.IntNum("Введите номер объекта: ") - 1;

                                        if (index >= 0 && index < meowables.Count)
                                        {
                                            int count = Proverka.IntNum("Введите количество мяуканий: ");
                                            meowables[index].Meow(count);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Неверный номер объекта.");
                                        }
                                    }
                                    break;

                                case "6": // Пусть все мяукающие мяукнут один раз
                                    if (meowables.Count == 0)
                                    {
                                        Console.WriteLine("Список мяукающих пуст.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nМяукают все объекты:");
                                        Funs.MakeAllMeow(meowables, meowCounters);
                                    }
                                    break;

                                case "7":
                                    if (meowCounters.Count == 0)
                                    {
                                        Console.WriteLine("Ещё никто не мяукал.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nКоличество мяуканий каждого кота:");
                                        foreach (var entry in meowCounters)
                                        {
                                            Console.WriteLine($"{entry.Key}: {entry.Value} мяуканий");
                                        }
                                    }
                                    break;

                                case "8": // Вернуться в главное меню
                                    return;

                                default:
                                    Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                                    break;
                            }
                        }

                    case "2": // Работа с дробями
                        while (true)
                        {
                            Console.WriteLine("\nВыберите действие с дробями:");
                            Console.WriteLine("1. Создать дробь");
                            Console.WriteLine("2. Просмотреть все созданные дроби");
                            Console.WriteLine("3. Выполнить операцию с дробями");
                            Console.WriteLine("4. Выполнить выражение: дробь1 + дробь2 / дробь3 - 5");
                            Console.WriteLine("5. Сравнить 2 дроби");
                            Console.WriteLine("6. Клонировать дробь");
                            Console.WriteLine("7. Вычислить вещественное значение дроби");
                            Console.WriteLine("8. Задать числитель и знаменатель дроби");
                            Console.WriteLine("9. Завершить работу");
                            Console.Write("Ваш выбор: ");
                            string choice = Console.ReadLine();

                            switch (choice)
                            {
                                case "1": // Создать дробь
                                    try
                                    {
                                        Console.Write("Введите числитель: ");
                                        int numerator = int.Parse(Console.ReadLine());
                                        Console.Write("Введите знаменатель: ");
                                        int denominator = int.Parse(Console.ReadLine());
                                        Drobis.Add(new Drobi(numerator, denominator));
                                        Console.WriteLine("Дробь успешно создана!");
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine($"Ошибка: {ex.Message}");
                                    }
                                    break;

                                case "2": // Просмотреть дроби
                                    if (Drobis.Count == 0)
                                    {
                                        Console.WriteLine("Список дробей пуст.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nСписок всех дробей:");
                                        for (int i = 0; i < Drobis.Count; i++)
                                        {
                                            Console.WriteLine($"{i + 1}. {Drobis[i]}");
                                        }
                                    }
                                    break;

                                case "3":
                                    if (Drobis.Count < 1)
                                    {
                                        Console.WriteLine("Недостаточно дробей для выполнения операции. Создайте хотя бы ещё одну дробь.");
                                        break;
                                    }

                                    for (int i = 0; i < Drobis.Count; i++)
                                    {
                                        Console.WriteLine($"{i + 1}. {Drobis[i]}");
                                    }
                                    Console.Write("Выберите номер первой дроби: ");
                                    int firstIndex = int.Parse(Console.ReadLine()) - 1;

                                    if (firstIndex < 0 || firstIndex >= Drobis.Count)
                                    {
                                        Console.WriteLine("Некорректный выбор.");
                                        return;
                                    }

                                    Console.WriteLine("Выберите тип операции:");
                                    Console.WriteLine("1. Сложение");
                                    Console.WriteLine("2. Вычитание");
                                    Console.WriteLine("3. Умножение");
                                    Console.WriteLine("4. Деление");
                                    Console.WriteLine("5. С целым числом");
                                    Console.Write("Ваш выбор: ");
                                    string operation = Console.ReadLine();

                                    Drobi result = null;

                                    try
                                    {
                                        if (operation == "5")
                                        {
                                            Console.Write("Введите целое число: ");
                                            int number = int.Parse(Console.ReadLine());

                                            Console.WriteLine("Выберите операцию (1 - сложение, 2 - вычитание, 3 - умножение, 4 - деление): ");
                                            string numOperation = Console.ReadLine();

                                            switch (numOperation)
                                            {
                                                case "1":
                                                    result = Drobis[firstIndex].Plus(number);
                                                    Console.WriteLine($"{Drobis[firstIndex]} + {number} = {result}");
                                                    break;
                                                case "2":
                                                    result = Drobis[firstIndex].Minus(number);
                                                    Console.WriteLine($"{Drobis[firstIndex]} - {number} = {result}");
                                                    break;
                                                case "3":
                                                    result = Drobis[firstIndex].Umnozenie(number);
                                                    Console.WriteLine($"{Drobis[firstIndex]} * {number} = {result}");
                                                    break;
                                                case "4":
                                                    result = Drobis[firstIndex].Delenie(number);
                                                    Console.WriteLine($"{Drobis[firstIndex]} / {number} = {result}");
                                                    break;
                                                default:
                                                    Console.WriteLine("Некорректный выбор.");
                                                    return;
                                            }
                                        }
                                        else
                                        {
                                            if (Drobis.Count < 2)
                                            {
                                                Console.WriteLine("Недостаточно дробей для выполнения операции. Создайте хотя бы одну дробь.");
                                                break;
                                            }
                                            else
                                            {
                                                for (int i = 0; i < Drobis.Count; i++)
                                                {
                                                    Console.WriteLine($"{i + 1}. {Drobis[i]}");
                                                }
                                                Console.Write("Выберите номер второй дроби: ");
                                                int secondIndex = int.Parse(Console.ReadLine()) - 1;

                                                if (secondIndex < 0 || secondIndex >= Drobis.Count || secondIndex == firstIndex)
                                                {
                                                    Console.WriteLine("Некорректный выбор.");
                                                    return;
                                                }

                                                switch (operation)
                                                {
                                                    case "1":
                                                        result = Drobis[firstIndex].Plus(Drobis[secondIndex]);
                                                        Console.WriteLine($"{Drobis[firstIndex]} + {Drobis[secondIndex]} = {result}");
                                                        break;
                                                    case "2":
                                                        result = Drobis[firstIndex].Minus(Drobis[secondIndex]);
                                                        Console.WriteLine($"{Drobis[firstIndex]} - {Drobis[secondIndex]} = {result}");
                                                        break;
                                                    case "3":
                                                        result = Drobis[firstIndex].Umnozenie(Drobis[secondIndex]);
                                                        Console.WriteLine($"{Drobis[firstIndex]} * {Drobis[secondIndex]} = {result}");
                                                        break;
                                                    case "4":
                                                        result = Drobis[firstIndex].Delenie(Drobis[secondIndex]);
                                                        Console.WriteLine($"{Drobis[firstIndex]} / {Drobis[secondIndex]} = {result}");
                                                        break;
                                                    default:
                                                        Console.WriteLine("Некорректный выбор.");
                                                        return;
                                                }
                                            }
                                        }
                                        Drobis.Add(result);
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine($"Ошибка: {ex.Message}");
                                    }
                                    break;

                                case "4": // Выполнить выражение с дробями
                                    if (Drobis.Count < 3)
                                    {
                                        Console.WriteLine("Недостаточно дробей для выполнения выражения. Создайте хотя бы три дроби.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Список дробей:");
                                        for (int i = 0; i < Drobis.Count; i++)
                                        {
                                            Console.WriteLine($"{i + 1}. {Drobis[i]}");
                                        }
                                        Console.Write("Выберите первую дробь: ");
                                        int index1 = int.Parse(Console.ReadLine()) - 1;
                                        Console.Write("Выберите вторую дробь: ");
                                        int index2 = int.Parse(Console.ReadLine()) - 1;
                                        Console.Write("Выберите третью дробь: ");
                                        int index3 = int.Parse(Console.ReadLine()) - 1;

                                        if (index1 >= 0 && index2 >= 0 && index3 >= 0 &&
                                            index1 < Drobis.Count && index2 < Drobis.Count && index3 < Drobis.Count)
                                        {
                                            Drobi result1 = Drobis[index1].Plus(Drobis[index2].Delenie(Drobis[index3])).Minus(5);
                                            Console.WriteLine($"{Drobis[index1]} + {Drobis[index2]} / {Drobis[index3]} - 5 = {result1}");
                                            Drobis.Add(result1);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Некорректный выбор.");
                                        }
                                    }
                                    break;


                                case "5":
                                    if (Drobis.Count < 2)
                                    {
                                        Console.WriteLine("Недостаточно дробей для выполнения выражения. Создайте хотя бы 2 дроби.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Список дробей:");
                                        for (int i = 0; i < Drobis.Count; i++)
                                        {
                                            Console.WriteLine($"{i + 1}. {Drobis[i]}");
                                        }
                                        Console.Write("Выберите первую дробь: ");
                                        int index1 = int.Parse(Console.ReadLine()) - 1;
                                        Console.Write("Выберите вторую дробь: ");
                                        int index2 = int.Parse(Console.ReadLine()) - 1;
                                        if (index1 >= 0 && index2 >= 0 &&
                                            index1 < Drobis.Count && index2 < Drobis.Count && index1 != index2)
                                        {
                                            bool resultBool;
                                            if (resultBool = (Drobis[index1] == Drobis[index2]))
                                            {
                                                Console.WriteLine("Дроби равны");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Дроби не равны");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Некорректный выбор.");
                                        }

                                    }
                                    break ;

                                case "6":
                                    if (Drobis.Count < 1)
                                    {
                                        Console.WriteLine("Недостаточно дробей для выполнения выражения. Создайте хотя бы одну дробь.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Список дробей:");
                                        for (int i = 0; i < Drobis.Count; i++)
                                        {
                                            Console.WriteLine($"{i + 1}. {Drobis[i]}");
                                        }
                                        Console.WriteLine("Выберите номер дроби для копирования: ");
                                        int indexC = int.Parse(Console.ReadLine()) - 1;
                                        if (indexC < 0 || indexC >= Drobis.Count)
                                        {
                                            Console.WriteLine("Некорректный выбор.");
                                            return;
                                        }
                                        else
                                        {
                                            Drobi res = (Drobi)Drobis[indexC].Clone();
                                            Drobis.Add(res);
                                        }
                                        
                                    }
                                    break ;

                                case "7":
                                    if (Drobis.Count < 1)
                                    {
                                        Console.WriteLine("Недостаточно дробей для выполнения выражения. Создайте хотя бы одну дробь.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Список дробей:");
                                        for (int i = 0; i < Drobis.Count; i++)
                                        {
                                            Console.WriteLine($"{i + 1}. {Drobis[i]}");
                                        }
                                        Console.Write("Выберите дробь: ");
                                        int index1 = int.Parse(Console.ReadLine()) - 1;
                                        Console.WriteLine($"Вещественное значение дроби: {Drobis[index1].GetVeshValue()}");

                                    }
                                    break;

                                case "8":
                                    if (Drobis.Count < 1)
                                    {
                                        Console.WriteLine("Недостаточно дробей для выполнения выражения. Создайте хотя бы одну дробь.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Список дробей:");
                                        for (int i = 0; i < Drobis.Count; i++)
                                        {
                                            Console.WriteLine($"{i + 1}. {Drobis[i]}");
                                        }
                                        Console.Write("Выберите дробь: ");
                                        int index1 = int.Parse(Console.ReadLine()) - 1;
                                        Console.WriteLine("Задайте числитель: ");
                                        int chisl = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Задайте числитель: ");
                                        int znamen = int.Parse(Console.ReadLine());
                                        Drobis[index1].SetChislitZnach(chisl, znamen);
                                        Console.WriteLine($"Измененная дробь: {Drobis[index1]}");
                                    }
                                    break;

                                case "9": // Вернуться в главное меню
                                    return;

                                default:
                                    Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                                    break;
                            }
                        }
    

                    case "3": // Завершение программы
                        Console.WriteLine("Работа завершена.");
                        return;

                    default:
                        Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                        break;
                }
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Множество
{
    class Program
    {
        static void Main(string[] args)
        { //Использование методов множеств
          //для работы с коллекциями (массивами)
            int[] mas1 = { 15, 25, -56, 1, 0, 
                -100, 555, 79, 333, -1000 };
            int[] mas2 = { -56, 0, -100, 666, 
                777, -999, 2332 };

            printArray(mas1);
            printArray(mas2);
            //#1 Объединение  - Union
            IEnumerable<int> masUnion = mas1.Union(mas2);
            printSet(masUnion);
            //#2 Пересечение  - Intersect
            IEnumerable<int> masIntersect = mas1.Intersect(mas2);
            printSet(masIntersect);
            //#3 Разность - Except
            IEnumerable<int> masExcept = mas1.Except(mas2);
            printSet(masExcept);
            IEnumerable<int> masExcept2 = mas2.Except(mas1);
            printSet(masExcept2);

            //с.82, №1
            string[] flower = {"Анжелика", "Виктория",
            "Гагарин", "Катарина", "Юбилейная", "AveMaria"};//исходное множество
            string[] flower1 = {"Анжелика", "Виктория",
            "Гагарин", "Катарина", "Юбилейная", 
                "Красная", "Чайная", "Принц"};
            string[] flower2 = { "Виктория",
            "Гагарин", "Катарина",  "Красная",
                "Чайная",  "BluSky"};
            string[] flower3 = {"Анжелика", "Виктория",
             "Юбилейная", "RedFair", "Чайная", "Принц"};
            //есть у каждого
            var rez1 = flower.Intersect(flower1).Intersect(flower2).Intersect(flower3);
            Console.WriteLine("Сорта роз у каждого");
            PrintSet(rez1);
            //есть хотя бы у одного
            var rez2 = flower1.Union(flower2).Union(flower3).Intersect(flower);
            Console.WriteLine("Сорта роз хотя бы у одного");
            PrintSet(rez2);
            //нет ни у одного
            var rez3 = flower.Except(flower1).Except(flower2).Except(flower3);
            Console.WriteLine("Сорта роз нет ни у одного");
            PrintSet(rez3);


            Console.ReadKey();
            //    string[] planets1 = { "Mercury", 
            //        "Venus", "Neptune",
            //        "Earth", "Jupiter" };
            //    string[] planets2 = { "Mercury", 
            //        "Earth", 
            //        "Mars", "Jupiter" };
            //    string[] MN = { };//пустое множество
            //    Console.WriteLine("объединение множеств");
            //    // объединение множеств
            //    IEnumerable<string> result = planets1.Union(planets2);
            //    Print_mnozh(result);
            //    Console.WriteLine(result);

            //    Console.WriteLine("пересечение множеств");
            //    // пересечение множеств

            //    var result1 = planets1.Intersect(planets2);

            //    Print_mnozh(result1);
            //    Console.WriteLine($"Количество элементов в множестве = {result1.Count()}");
            //    Console.WriteLine("разность множеств");
            //    // разность множеств

            //    var result2 = planets1.Except(planets2);
            //    // 
            //    Print_mnozh(result2);

            //    Console.WriteLine("простое объединение множест");
            //    // простое объединение множеств

            //    var result3 = planets1.Concat(planets2);
            //    Print_mnozh(result3);
            //    result3 = result3.Distinct();
            //    Console.WriteLine("Без повторов");
            //    Print_mnozh(result3);

            //    int[] mn = { 1, 3, 5, 7 };

            //    //добавление элемента в множество
            //    IEnumerable<int> mn1 = Insert_elem(mn);
            //    Console.WriteLine("Множество:");
            //    foreach (int i in mn1)
            //        Console.Write($"{i}  ");

            //    //Агрегирующие функции
            //    Console.WriteLine();
            //    Console.WriteLine("Агрегирующие функции");
            //    Console.WriteLine($"Сумма: {mn1.Sum()}");//25
            //    Console.WriteLine($"Среднее арифметическое: {mn1.Average()}");//5
            //    Console.WriteLine($"Минимум: {mn1.Min()}");//1
            //    Console.WriteLine($"Максимум: {mn1.Max()}");//9
            //    Console.WriteLine($"Количество: {mn1.Count()}");//5
            //    Console.WriteLine($"Содержит 5? {mn1.Contains(5)}");//true
            //    Console.WriteLine($"Содержит 6? {mn1.Contains(6)}");//false
            //    Console.WriteLine("Для выхода из программы нажмите Y");
            //    Exit();

            //}

            //private static IEnumerable<int> Insert_elem(int[] mn)
            //{
            //    int[] a = { int.Parse(Console.ReadLine()) };//9
            //    var mn1 = mn.Union(a);
            //    return mn1;
            //}

            //private static void Exit()
            //{
            //    ConsoleKeyInfo cki = Console.ReadKey();
            //    while (cki.Key != ConsoleKey.Y)
            //    {
            //        Console.WriteLine("Вы не нажали Y");
            //        cki = Console.ReadKey(false);
            //    }
            //}

            //private static void Print_mnozh(IEnumerable<string> res)
            //{
            //    foreach (string s in res)
            //        Console.WriteLine(s);
            //}

        }

        private static void PrintSet(IEnumerable<string> rez1)
        {
            foreach (var fl in rez1)
            {
                Console.WriteLine(fl);
            }
        }

        private static void printSet(IEnumerable<int> mas)
        {
            foreach (int x in mas)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }

        private static void printArray(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]} ");
            }
            Console.WriteLine();

        }
    }
}

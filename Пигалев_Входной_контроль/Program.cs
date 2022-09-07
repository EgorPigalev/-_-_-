using System;
using System.Collections;


namespace Пигалев_Входной_контроль
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите действие:\n1 - Задание 1;\n2 - Задание 2;\n3 - Задание 3;\n4 - Задание 4;\n5 - Задание 5;\n6 - Задание 6;\n7 - Задание 7;\n8 - Задание 8;\n9 - Завершить работу программы;");
                int nomer = Convert.ToInt32(Console.ReadLine());
                switch (nomer)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Задание номер 1");
                        ShowStepen();
                        Console.WriteLine("Чтобы продолжить нажмите любую клавишу ...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Задание номер 2");
                        ShowPerimetrPloshad();
                        Console.WriteLine("Чтобы продолжить нажмите любую клавишу ...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Задание номер 3");
                        ShowProverkaDelen();
                        Console.WriteLine("Чтобы продолжить нажмите любую клавишу ...");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Задание номер 4");
                        ShowтNumber();
                        Console.WriteLine("Чтобы продолжить нажмите любую клавишу ...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Задание номер 5");
                        ShowPrimer();
                        Console.WriteLine("Чтобы продолжить нажмите любую клавишу ...");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Задание номер 6");
                        ShowFibonachi();
                        Console.WriteLine("Чтобы продолжить нажмите любую клавишу ...");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Задание номер 7");
                        ShowResultPosled();
                        Console.WriteLine("Чтобы продолжить нажмите любую клавишу ...");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Задание номер 8");
                        ShowBestResult();
                        Console.WriteLine("Чтобы продолжить нажмите любую клавишу ...");
                        Console.ReadKey();
                        break;
                }
                if (nomer == 9)
                {
                    break;
                }
                Console.Clear();
            }

        }
        public static void ShowStepen() // Задание 1
        {
            Console.WriteLine("Введите первое вещественное число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе вещественное число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(a + " в степени " + b + " равен " + Math.Pow(a, b));
        }
        public static void ShowPerimetrPloshad() // Задание 2
        {
            Console.WriteLine("Введите x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double a = Math.Sqrt(Math.Pow((x1 - x2), 2));
            double b = Math.Sqrt(Math.Pow((y1 - y2), 2));
            double c = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            Console.WriteLine("Периметр равен  " + (a + b + c));
            Console.WriteLine("Площадь равна  " + (0.5 * (a+b)));
        }
        public static void ShowProverkaDelen() // Задание 3
        {
            Console.WriteLine("Введите вещественное число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            if((a % 2) == (a % 3))
            {
                Console.WriteLine("Число " + a + " при деление на 2 и 3 даёт одинаковый остаток");
            }
            else
            {
                Console.WriteLine("Число " + a + " при деление на 2 и 3 даёт одинаковый остаток");
            }
        }
        public static void ShowтNumber() // Задание 4
        {
            Console.WriteLine("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            string str = Convert.ToString(a);
            for(int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str.Substring(0, i+1));
            }
        }
        public static void ShowPrimer()// Задание 5
        {
            Console.WriteLine("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double result = (1 + Math.Sin(Math.Sqrt(x + 1))) / (Math.Cos(12 * y - 4));
            Console.WriteLine("Результат выражения равен " + result);
        }
        public static void ShowFibonachi() // Задание 6
        {
            int[] array = new int[2];
            array[0] = 0;
            array[1] = 1;
            Console.WriteLine("Введите длину последовательности: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 2; i < n; i++)
            {
                Array.Resize(ref array, array.Length + 1);
                array[i] = array[i - 1] + array[i - 2];
            }
            for (int i = 0; i < n; i++)
            {
                if((i+1)%2 == 0)
                {
                    Console.WriteLine("индекс " + (i+1) + " -> " + array[i]);
                }
            }
        }
        public static void ShowResultPosled() // Задание 7
        {
            Console.WriteLine("Введите длину последовательности: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double summa = 0;
            for(int i = 0; i < n; i++)
            {
                summa = summa + ((double)(i + 1) / (double)(i + 2));
            }
            Console.WriteLine("Сумма последовательности равна " + summa);
        }
        public static void ShowBestResult() // Задание 8
        {
            Console.WriteLine("Введите результат по плаванию 1 спортсмена: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите результат по плаванию 2 спортсмена: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите результат по плаванию 3 спортсмена: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a >= b && a >= c)
            {
                if(a >= c)
                {
                    Console.WriteLine(a + " это результат победителя заплыва");
                }
                else
                {
                    Console.WriteLine(c + " это результат победителя заплыва");
                }
            }
            else
            {
                if (b >= c)
                {
                    Console.WriteLine(b + " это результат победителя заплыва");
                }
                else
                {
                    Console.WriteLine(c + " это результат победителя заплыва");
                }
            }
        }
    }
}
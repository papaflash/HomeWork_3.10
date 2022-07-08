using System;

namespace Task01_OddEvenNumber
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            /// <summary>
            /// Задание 1. Написать программу определения четного/нечетного числа.
            /// </summary>
            Console.WriteLine("Программа определиня четного/нечетного числа");
            while (true)
            {
                Console.Write("Введите число: ");
                int _number = int.Parse(Console.ReadLine());
                if (_number % 2 == 0) Console.WriteLine("Вы ввели четное число");
                else Console.WriteLine("Вы ввели нечетное число");
                Console.Write("Для продолжения нажмите Enter, для остановки программы введите - (N/n): ");
                string _answer = Console.ReadLine();
                if (_answer.ToLower() == "n") break;
            }    
        }
    }
}

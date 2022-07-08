using System;

namespace Task03_SimpleNum
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            /// <summary>
            /// Задача 3. Написать программу которая проверяет является ли введеное число простым
            /// </summary>
            Console.WriteLine("Программа проверки простого числа");
            Console.WriteLine(new String('=', 100));
            Console.Write("Введите число для проверки: ");
            bool _flag = false;
            if(!int.TryParse(Console.ReadLine(), out int _num))
            {
                Console.WriteLine("Вы ввели не допустимое значение!");
                return;
            }
            if (_num <= 2 && _num >= -2) _flag = true;
            else if (_num < 0) _num *= -1;
            int i = _num - 1;
            while(i > 1)
            {
                if(_num % i == 0) _flag = true;
                i--;
            }
            if (_flag) Console.WriteLine($"Число {_num} не является простым!");
            else Console.WriteLine($"Поздравляем! Вы ввели простое число!");
        }
    }
}

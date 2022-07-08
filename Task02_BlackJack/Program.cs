using System;

namespace Task02_BlackJack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Задание 2. Программа подсчета суммы карт в игре BlackJack.
            /// </summary>
            Console.WriteLine("Программа подсчета суммы карт в игре BlackJack");
            Console.WriteLine(new String('=', 100));
            Console.WriteLine("Правила: Значение карт может быть от 2 до 10.\nКарты с картинками означают 10 очков" +
                " и обозначаются латинскими буквами\nT - Туз\nK - Король\nQ - Дама\nJ - Валет");
            Console.WriteLine(new String('=', 100));
            Console.Write("Введите общее кол-во карт в руке: ");
            if (!ushort.TryParse(Console.ReadLine(), out ushort _countCards))
            {
                Console.WriteLine("Вы ввели не допустимое кол-во карт!");
                return;
            }
            ushort _sum = 0;
            string _currCard;
            const ushort PICTURE_CARD = 10;
            for (ushort i = 1; i <= _countCards; i++)
            {
                Console.Write($"Введите значение карты №{i}: ");
                _currCard = Console.ReadLine().ToUpper();
                switch (_currCard)
                {
                    case "Q":
                        _sum += PICTURE_CARD;
                        break;
                    case "J":
                        _sum += PICTURE_CARD;
                        break;
                    case "T":
                        _sum += PICTURE_CARD;
                        break;
                    case "K":
                        _sum += PICTURE_CARD;
                        break;
                    default:
                        if (ushort.TryParse(_currCard, out ushort _currCardNum) && _currCardNum >= 2 && _currCardNum <= 10)
                        {
                            _sum += _currCardNum;
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели не допустимое значение!");
                            i--;
                        }
                        break;
                }           
            }
            Console.WriteLine($"Сумма карт равна: {_sum}");
            Console.ReadKey();
        }
    }
}

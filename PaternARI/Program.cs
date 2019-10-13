using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternARI
{
    class Program
    {
        static Presenter presenter = new Presenter();

        static void Main(string[] args)
        {
            Print();
            for (; ; )
            {
                Console.WriteLine("Выберите операцию:\n" +
                    " 1-Добавить элемент\n" +
                    " 2-Удалить элемент\n" +
                    " 3-Вывести массив\n" +
                    " 4-Задание по варианту\n" +
                    " 5-Удалить первый четный элемент\n");
                int x;
                string k = Console.ReadLine();
                if (Int32.TryParse(k, out x))
                {
                    
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Введите число:");
                        int value;
                        string s = Console.ReadLine();
                        if (Int32.TryParse(s, out value))
                        {
                            presenter.Add(value);
                            Print();
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Какой элемент удалить?");
                        int del;
                        string k1 = Console.ReadLine();
                        if (Int32.TryParse(k1, out del))
                        {
                            presenter.Remove(del);
                            Print();
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод");
                        }
                        break;
                    case 3:
                        Print();
                        break;
                    case 4:
                        presenter.Sort();
                        Print();
                        break;
                    case 5:
                        presenter.Delete2n();
                        Print();
                        break;
                    default:

                        Console.WriteLine("Пользователь дурачок");
                        break;
                }
            }
        }
        public static void Print()
        {
            foreach (int value in presenter.array)
            {
                Console.Write($" {value} ");
            }
            Console.WriteLine();
        }

    }

}

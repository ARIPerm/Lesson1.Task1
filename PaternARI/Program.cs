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

                int inputKey;
                if (Int32.TryParse(Console.ReadLine(), out inputKey))
                {
                    switch (inputKey)
                    {
                        case 1:
                            Console.WriteLine("Введите число:");
                            int value;
                            if (Int32.TryParse(Console.ReadLine(), out value))
                            {
                                presenter.Add(value);
                            }
                            else
                            {
                                PrintError();
                            }
                            break;
                        case 2:
                            Console.WriteLine("Какой элемент удалить?");
                            int index;
                            if (Int32.TryParse(Console.ReadLine(), out index))
                            {
                                presenter.Remove(index);
                            }
                            else
                            {
                                PrintError();
                            }
                            break;
                        case 3:
                            break;
                        case 4:
                            presenter.Sort();
                            break;
                        case 5:
                            presenter.Delete2n();
                            break;
                        default:

                            Console.WriteLine("Пользователь дурачок");
                            break;
                    }
                    Print();
                }
                else
                {
                    PrintError();
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
        public static void PrintError()
        {
            Console.WriteLine("Некорректный ввод");
        }

    }

}

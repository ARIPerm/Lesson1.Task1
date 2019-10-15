using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternARI
{
    public class Presenter
    {
        private static int START_VALUE = 5;
        static Random rnd = new Random();
        public int[] array;

        public Presenter()
        {
            array = new int[START_VALUE];
            for (int i = 0; i < START_VALUE; i++)
            {
                array[i] = rnd.Next(-10, 10);
            }
        }

        public void Add(int item)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = item;
        }

        public void Remove(int index)
        {
            for (int i = index - 1; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, array.Length - 1);
        }

        public void Delete2n()
        {
            int temp;
            bool flag = true;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 2) == 0 && array[i] != 0 && flag)
                {
                    flag = false;
                    for (int k = i; k < array.Length - 1; k++)
                    {
                        Temp(k, 1);
                    }
                    Array.Resize(ref array, array.Length - 1);
                }
            }
            if (flag)
            {
                Console.WriteLine("У вас нет четных чисел");
            }
        }

        public void Sort()
        {
            int temp;
            for (int i = 0; i < array.Length - 2; i++)
            {
                if (i % 2 == 0 || i == 0)
                {
                    if (array[i] > array[i + 2])
                    {
                        Temp(i, 2);
                    }
                }
            }
        }

        public void Temp(int index, int step)
        {
            int temp;
            temp = array[index];
            array[index] = array[index + step];
            array[index + step] = temp;
        }

    }

}

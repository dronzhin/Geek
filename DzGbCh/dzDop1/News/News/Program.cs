using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News
{
    internal class Program
    {
        static int randonNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        static void Main(string[] args)
        {
            int lengthArray = randonNumber(5, 30);
            Console.WriteLine("Длина массива - " + lengthArray);
            var array = Enumerable.Range(1, lengthArray).ToArray();
            int scrollNews = 12;
            int showNews = randonNumber(1, lengthArray);
            int startNews = randonNumber(1, lengthArray);
            string scrollNewsShow = string.Empty;
            int count = scrollNews / lengthArray;
            if (lengthArray < scrollNews)

            {
                for (int i = 0; i < count; i++)
                {
                    for (int j = startNews - 1; j < lengthArray; j++)
                    {
                        scrollNewsShow += array[j] + " ";
                    }
                    for (int j = 0; j < startNews - 1; j++)
                    {
                        scrollNewsShow += array[j] + " ";
                    }
                }

                for (int i = startNews - 1; i < scrollNews - count*lengthArray; i++)
                {
                    scrollNewsShow += array[i] + " ";
                }
            }
            else
            {
                for (int i = startNews - 1; i < lengthArray; i++)
                {
                    scrollNewsShow += array[i] + " ";
                }
                for (int i = 0; i < scrollNews - (lengthArray-startNews)-1; i++)
                {
                    scrollNewsShow += array[i] + " ";
                }
            }
            Console.WriteLine("Прокучивает новости - " + scrollNewsShow);
            Console.WriteLine("Показывает новость - " + showNews);
            Console.ReadKey();
        }
    }
}

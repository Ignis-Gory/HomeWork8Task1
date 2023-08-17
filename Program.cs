using System;
using System.Collections.Generic;

namespace HomeWorkLesson8
{

    

    class Program
    {
        /// <summary>
        /// Метод выводящий коллекцию на экран
        /// </summary>
        /// <param name="felloyNumber"></param>
        static void ShowCollection(List<int> felloyNumber)
        {
            Console.WriteLine();
            for (int i = 0; i < felloyNumber.Count; i++)
            {
                Console.Write(felloyNumber[i] + "\t");
            }
           
            Console.WriteLine();
        }

        /// <summary>
        /// Метод заполняющий коллекцию случайным набором чисел
        /// </summary>
        /// <param name="felloyNumber"></param>
        /// <returns></returns>
        static List<int> FillingArray (List<int> felloyNumber)
        {
            Random randomNumber = new Random();


            for (int i = 0; i < 100; i++)
            {
                felloyNumber.Add(randomNumber.Next(0, 100));
            }

            return felloyNumber;
        }

        static List<int> CleanArray(List<int> felloyNumber)
        {
            for (int i = 26; i < 50; i++)
            {
                do
                {
                    if (felloyNumber.Contains(i))
                    {
                        int index = felloyNumber.IndexOf(i);
                        felloyNumber.RemoveAt(index);
                    }
                    else
                    {
                        break;
                    }

                } while (true);
            }
            return felloyNumber;
        }

        static void Main(string[] args)
        {
            List<int> felloyNumber = new List<int>();

            felloyNumber = FillingArray(felloyNumber);

            ShowCollection(felloyNumber);

            felloyNumber = CleanArray(felloyNumber);

            ShowCollection(felloyNumber);

        }
    }
}

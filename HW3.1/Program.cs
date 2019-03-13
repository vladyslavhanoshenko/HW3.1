using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace HW3._1
{
    class Program
    {
        public static List<int> items = new List<int>();

        public static void ShortList()
        {
            if (items.Count() >= 2)
            {
                Console.WriteLine("Your short list is:");
                Console.WriteLine($"{items[0]} {items[items.Count - 1]}");
            }
            else
            {
                ShortList();
            }
        }
        public static void ShowList()
        {
            foreach (var item in items)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static void DescendOrder()
        {
            Console.WriteLine("Your sorted descending list is: ");
            items.Sort();
            items.Reverse();
            ShowList();
        }
        public static void Run()
        {
            Console.WriteLine("Please enter int items to the list(enter 'stop' to finish:)");
            while (true)
            {
                string inputString = Console.ReadLine();
                if (inputString == "stop")
                {
                    break;
                }

                var isInt = int.TryParse(inputString, out var digit);
                if (!isInt)
                {
                    Console.WriteLine("Entered value is not an int. Please enter a number: ");
                    continue;
                }
                else
                {
                    items.Add(digit);
                }
            }
            if (items.Count == 0)
            {
                Environment.Exit(0);
            }

            Console.WriteLine("Your list is:");
            ShowList();
        }
        static void Main(string[] args)
        {
            Run();
            DescendOrder();
            ShortList();

            Console.ReadKey();
        }
    }
}


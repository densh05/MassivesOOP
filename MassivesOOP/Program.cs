using System;
using System.Text;

// Індексатори.

namespace Indexers
{
    class MyClass
    {
        private string[] array = new string[5];

        // Індексатор. 
        public string this[int index]
        {
            get    // Аксесор.
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                else
                    return "Спроба звернення за межі масиву.";
            }
            set    // Мутатор.
            {
                if (index >= 0 && index < array.Length)
                    array[index] = value;
                else
                    Console.WriteLine("Спроба запису за межами масиву.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            MyClass my = new MyClass();

            my[0] = "string 1";
            my[1] = "string 2";
            my[2] = "string 3";
            my[3] = "string 4";
            my[4] = "string 5";
            my[5] = "string 6";


            Console.WriteLine(my[0]);
            Console.WriteLine(my[1]);
            Console.WriteLine(my[2]);
            Console.WriteLine(my[3]);
            Console.WriteLine(my[4]);
            Console.WriteLine(my[5]);


            // Delay.
            Console.ReadKey();
        }
    }
}

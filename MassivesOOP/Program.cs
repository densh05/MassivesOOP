using System;

namespace MassivesOOP
{
    class MyClass
    {
        private int[] array = new int[5];

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
    }

    internal class Program
    {
 
        static void Main(string[] args)
        {
            MyClass my = new MyClass();

            my[0] = 1;
            my[1] = 2;
            my[2] = 3;
            my[3] = 4;
            my[4] = 5;
             
            Console.WriteLine(my[0]);
            Console.WriteLine(my[1]);
            Console.WriteLine(my[2]);
            Console.WriteLine(my[3]);
            Console.WriteLine(my[4]);
            
        }
    }
}

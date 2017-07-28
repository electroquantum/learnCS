using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Scope
//      public
//      private
//      protected
//      internal
//      protected internal

namespace _01_HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        // Args dosn't include the program name.
        {
            System.Console.WriteLine("Hello World!");
            // WriteLine() shows the parameter followed by a new line on the standard output.
            System.Console.ReadKey();
            // ReadKey() to prevent the console window from closing.

            Person p1 = new Person("Elisa", "Wan");
            p1.Stampa();
            System.Console.ReadKey();

            int[] arrayInt3 = { 0, 1, 2 };
            int[] arrayInt4 = new int[4];
            // ArrayInt4 is automatically initialized to ZERO

            int[] arrayInt5;
            arrayInt5 = new int[5];

            int[] arrayInt6;
            arrayInt6 = new int[] { 0, 1, 2, 3, 4, 5, 6 };

            int arrayInt4Length = arrayInt4.Length;
            int arrayInt4Rank = arrayInt4.Rank;

            int[,] array2D = new int[4, 2];
            // Array2D is an 2-dimension array with 4 rows and 2 columns
            int[,,] array3D = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                                 { { 7, 8, 9 }, { 10, 11, 12 } } };

            foreach (int i in arrayInt6)
            {
                Console.Write("{0}", i);
            }
            Console.WriteLine();
            System.Console.ReadKey();

            MyClass m1 = new MyClass();
            Console.WriteLine(m1.Number);
            Console.WriteLine(m1.Hours);
            m1.Hours = 5;
            Console.WriteLine(m1.Hours);
            Console.ReadKey();

        }
    }

    struct MyStruct
    {

    }

    interface MyInterface
    {

    }

    delegate int MyDelegate();

    enum MyEnum
    {

    }

    namespace MyNestedNameSpace
    {

    }

    class Person
    {
        string firstName;
        string lastName;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void Stampa()
        {
            System.Console.WriteLine("First name:" + this.firstName + "Last name:" + this.lastName);
        }
    }

    class Methods
    {
        public static void UseParams(string msg, params int[] intList)
        {
            // Params is a keyword to declare a variable number of arguments
            // it must be the last declared argument.
            int listLenght = intList.Length;
            Console.WriteLine(msg);
            foreach (int i in intList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void UseRef(ref int i)
        {
            // Ref is a keyword for passing an argument by reference
            // by default (if "ref" is not specified) arguments are passed by value.
            i++;
        }
    }

   
}

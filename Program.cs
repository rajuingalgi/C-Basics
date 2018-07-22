using System;

namespace CSharpBasics
{
    class Program
    {
        class Rectangle
        {
            // Member variables
            double length;
            double width;
            public void Acceptdetails()
            {
                length = 4.5;
                width = 3.5;
            }
            public double GetArea()
            {
                return length * width;
            }
            public void Display()
            {
                Console.WriteLine("Length: {0}", length);
                Console.WriteLine("Width: {0}", width);
                Console.WriteLine("Area: {0}", GetArea());
            }
        }
        class FunctionOverload
        {
            public int FindMax(int num1, int num2)
            {               
                return Math.Max(num1, num2);
            }

            public int FindMax(int num1, int num2, int num3)
            {                
                return Math.Max(num1, Math.Max(num2, num3));
            }
        }
        static void Main(string[] args)
        {
            /* My First Program in C# */
            Console.WriteLine("Hello World");

            /* My Second Program in C# */
            int num;
            Console.Write("\nEnter a value of N: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nValue of N: {0}\n", num);

            /* Area of Rectangle Program in C# */
            Rectangle rect = new Rectangle();
            rect.Acceptdetails();
            rect.Display();           

            /* sizeof in C# */
            Console.WriteLine("Size of int: {0} \n", sizeof(int));

            object obj;
            obj = 100;      // this is boxing

            // ast double to int.
            double d = 5673.74; int i;
            i = (int)d;

            // Addition of two numbers
            int new_i = 75; float new_f = 53.005f; double new_d = 2345.7652; bool new_b = true;

            Console.WriteLine("Integer value of i: " + new_i.ToString());
            Console.WriteLine("Integer value of f: " + new_f.ToString());
            Console.WriteLine("Integer value of d: " + new_d.ToString());
            Console.WriteLine("Boolean value of b: " + new_b.ToString());

            short a; int b; double c;
            /* Actual initialization */
            a = 10; b = 20;
            c = a + b;
            Console.WriteLine("\nA = {0}, B = {1}, Addition of A and B = {2}", a, b, c);

            // Constant declaration 
            const double pi = 3.14159;
            double r;
            Console.Write("\nEnter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * r * r;
            Console.WriteLine("\nValue of Radius: {0}, \tArea: {1}", r, areaCircle);

            // Function overloading
            Console.Write("\nEnter value of X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter value of Y: ");
            int y = Convert.ToInt32(Console.ReadLine());         
            Console.Write("\nEnter value of Z: ");
            int z = Convert.ToInt32(Console.ReadLine());
            FunctionOverload fn = new FunctionOverload();
            Console.Write("\nMax between X and Y : {0}", fn.FindMax(x, y));
            Console.Write("\n\nMax between X,Y and Z: {0}", fn.FindMax(x, y, z));
            Console.ReadKey();
        }
    }
}

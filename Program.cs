using System;
using System.Collections;
delegate void NumberChanger(int n);

namespace CSharpBasics
{
    class Program
    {        
        static int num = 10;
        public static void AddNum(int p)
        {
            num += p;
            Console.WriteLine("\nNamed Method: {0}", num);
        }
        public static void MultNum(int p)
        {
            num *= p;
            Console.WriteLine("\nNamed Method: {0}", num);
        }
        public static int GetNum()
        {
            return num;
        }
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
        class StackView
        {
            public void StackOperation()
            {
                Stack s = new Stack();  // LIFO - Last In First Out
                s.Push(1);  // Push for Add in Stack
                s.Push(2);
                s.Push(3);
                s.Push(4);
                s.Push(5);
                s.Pop();    // Pop for Remove from Stack 
                foreach (int i in s)
                {
                    Console.WriteLine("\nStack Value: {0}", i);
                }

            }
        }
        class QueueView
        {
            public void QueueOperation()
            {
                Queue q = new Queue();      // FIFO - First In First Out
                q.Enqueue(1);   // Enqueue for Add in Queue
                q.Enqueue(2);
                q.Enqueue(3);
                q.Enqueue(4);
                q.Enqueue(5);
                q.Dequeue();    // Dequeue for Remove from Queue 
                foreach (int i in q)
                {
                    Console.WriteLine("\nQueue Value: {0}", i);
                }
            }
        }
        class BitArrayView
        {
            public void BitArrayOperations()
            {
                BitArray bitArray1 = new BitArray(8);
                BitArray bitArray2 = new BitArray(8);

                byte[] a = { 55 };
                byte[] b = { 75 };

                bitArray1 = new BitArray(a);
                bitArray2 = new BitArray(b);

                Console.WriteLine("\nBitArray1 Binary of Number 55:");
                foreach (int i in bitArray1)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("\nBitArray2 Binary of Number 75:");
                foreach (int j in bitArray2)
                {
                    Console.Write(j + " ");
                }            
            }
        }
        static void Main(string[] args)
        {
            try
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
                Console.Write("\n\nMax between X,Y and Z: {0}\n", fn.FindMax(x, y, z));

                // Array in C#
                int[] n = new int[10]; /* n is an array of 10 integers */
                int ii, jj;
                /* initialize elements of array n */
                for (ii = 0; ii < 10; ii++)
                {
                    n[ii] = ii + 100;
                }
                /* output each array element's value */
                for (jj = 0; jj < 10; jj++)
                {
                    Console.WriteLine("\nElement[{0}] = {1}", jj, n[jj]);
                }

                //from string literal and string concatenation
                string fname, lname;
                fname = "Raju";
                lname = "Ingalgi";

                char[] letters = { 'H', 'e', 'l', 'l', 'o' };
                string[] sarray = { "Hello", "From", "Aryan", "Enterprises" };

                string fullname = fname + lname;
                Console.WriteLine("Full Name: {0}", fullname);
                string greetings = new string(letters);
                Console.WriteLine("Greetings: {0}", greetings);
                string message = String.Join(" ", sarray);
                Console.WriteLine("Message: {0}", message);

                //formatting method to convert a value
                DateTime waiting = new DateTime(2018, 07, 22, 17, 58, 0);
                string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
                Console.WriteLine("Message: {0}", chat);
                StackView stackView = new StackView();
                stackView.StackOperation();
                QueueView queueView = new QueueView();
                queueView.QueueOperation();
                BitArrayView bitArrayView = new BitArrayView();
                bitArrayView.BitArrayOperations();

                // Create delegate instance using anonymous method.
                NumberChanger nc = delegate (int X)
                {
                    Console.WriteLine("\nAnonymous Method: {0}", X);
                };
                // Calling the delegate using anonymous method.
                nc(10);
                // Instanceing the delegate using the named method.
                nc = new NumberChanger(AddNum);
                // Calling the delegate using anonymous method.
                nc(15);
                Console.ReadKey();               
            }
            catch (Exception Code)
            {
                Console.WriteLine("Error Code : {0}", Code);
            }
        }
    }
}

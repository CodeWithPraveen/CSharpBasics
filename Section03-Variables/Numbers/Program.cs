using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program for the numbers
            int i = 10;
            
            //  Whole Numbers
            int a = -10;
            int b = 1_100_100;
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine("* int *" + sizeof(int));
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine("* short *"+ sizeof(short));
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);

            Console.WriteLine("* long *"+ sizeof(long));
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            Console.WriteLine("* uint *"+ sizeof(uint));
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(uint.MaxValue);

            Console.WriteLine("* float *"+ sizeof(float));
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            Console.WriteLine("* double *"+ sizeof(double));
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine("* decimal *"+ sizeof(decimal));
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);
        }
    }
}


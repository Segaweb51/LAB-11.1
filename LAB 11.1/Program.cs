using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_11._1
{
    class Program
    {
        static void My()
        {
            new Equation { };
        }
        struct Equation
        {

            private double first;
            private double second;
            private double zero;
            private double x;

            public Program(double k, double b)
            {
                first = k;
                second = b;
                zero = 0;
            }
            public void Read(double k, double b)
            {
                first = k;
                second = b;
                zero = 0;
                root();
            }
            public void root()
            {
                if (first != 0) x = (zero - second / first);
                Display();
            }
            public void Display()
            {
                Console.WriteLine("Значение x:{0}", x);
                Console.ReadKey();
            }
        }

    }
    class myProgram
    {
        static void Main(string[] args)
        {
            Program qwr = new Program(0, 0);
            Console.Write("Введите значение K: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b:");
            double j = 0;
            double s = Convert.ToDouble(Console.ReadLine());
            qwr.Read(h, s);

        }
    }
}
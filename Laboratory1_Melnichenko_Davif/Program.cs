using System;

delegate double MyDel1(int a, int b, int c);
delegate double MyDel2(double a, double b);
delegate int MyDel3();
delegate double MyDel4(MyDel3[] a);

namespace Laboratory1_Melnichenko_Davif
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDel1 avg = (a, b, c) => ((double)a + b + c) / 3.0;

            MyDel2 Add, Sub, Mul, Div;
            Add = (a, b) => a + b;
            Mul = (a, b) => a * b;
            Sub = (a, b) => a - b;
            Div = (a, b) => a / b;

            Random random = new Random();
            MyDel3 rndnum = () => random.Next();
            MyDel3[] arr =
            {
                rndnum,
                rndnum,
                rndnum,
                rndnum,
                rndnum
            };
            MyDel4 myDel4 = a =>
            {
                double sum = 0.0;
                foreach (var f in a)
                {
                    sum += f();
                }
                return sum / a.Length;
            };
            myDel4(arr);
        }
    }
}

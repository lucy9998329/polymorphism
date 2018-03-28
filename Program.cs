using System;

namespace polimorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var v1 = new Vehicle("", "", "");//create instance of vehicle if public but not if private or protected
            var c1 = new Car("", "", "");
            var t1 = new Tesla("", "", "");

            c1.Start();

            //var t1 = new Test2();
            //t1.Something();

            //var t3 = new Test3();
            //t3.Something();
        }
    }


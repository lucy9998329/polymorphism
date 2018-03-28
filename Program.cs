using System;

namespace polimorphism
{
    class Vehicle
    {
        public string Make {get; set;}
        public string Fuel {get; set;}
        public string Engine {get; set;}

    //property needs to have same name as class in this case Vehicle
        public Vehicle (string m, string f, string e){
        Make = m;
        Fuel = f;
        Engine = e;
    }
    public virtual void Start() {
        Console.WriteLine("use a key to start the car");

    }

    }
    //Car is subclass of Vehicle
    //enhire from Vehicle
    class Car : Vehicle{
        public Car(string m, string f, string e) : base (m, f, e){}//instances need to be created to be passed to Class Vehicle

        public override void Start() {
            //Console.WriteLine("use a key to start the car");
        }
    }
    //Tesla is subclass of Car
    class Tesla : Car {

        public Tesla(string m, string f, string e) : base (m, f, e){}//instances need to be created to be passed to Class Car
        public override void Start(){
            Console.WriteLine("press botton to start a car");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var v1 = new Vehicle("", "", "");//create instance of vehicle if public but not if private or protected
            var c1 = new Car("", "", "");
            var t1 = new Tesla("", "", "");
        }
    }
}

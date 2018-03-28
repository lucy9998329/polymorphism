using System;

namespace polimorphism
{
    //Tesla is subclass of Car
    class Tesla : Car {

        public Tesla(string m, string f, string e) : base (m, f, e){}//instances need to be created to be passed to Class Car
        public override void Start(){
            Console.WriteLine("press botton to start a car");

        }
    }


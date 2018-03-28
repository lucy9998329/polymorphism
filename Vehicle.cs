using System;

namespace polimorphism
{
    class Vehicle
    {
        public string Make {get; set;}
        public string Fuel {get; set;}
        public string Engine {get; set;}

    //property needs to have same name as class in this case Vehicle
        public Vehicle (string m, string f, string e){ //if I protect i can't create instance if I use private I can't use base
        Make = m;
        Fuel = f;
        Engine = e;
    }
    public virtual void Start() {//virtual allows you to override something
        Console.WriteLine("use a key to start the car");

    }

    }
    }

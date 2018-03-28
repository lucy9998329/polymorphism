namespace polimorphism
{
    //Car is subclass of Vehicle
    //enhire from Vehicle
    class Car : Vehicle{
        public Car(string m, string f, string e) : base (m, f, e){}//instances need to be created to be passed to Class Vehicle

        public override void Start() { //if I don't want this piece I can create the c1.Start(); on void main
            //Console.WriteLine("use a key to start the car");
        }
    }


using System;

namespace DefaulConstructors{

    class program{

        static void Main(string[] args){
            Console.WriteLine("This works now!");
            Console.ReadKey();

            Car sportscar = new Car();

            System.Console.WriteLine("Sports car model is {0}", sportscar.make_id);
            sportscar.GetType();

            var x  = new Car();

            System.Console.WriteLine(x);
        }
    }

    class Car{

        public string make_id;

        public Car(){
            System.Console.WriteLine("i am a DefaulConstructor");
        }

        public Car(string ID){
            System.Console.WriteLine("Yor car id is {0}", make_id = ID);
        }

     
    }
}
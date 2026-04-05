using System;

namespace MyFirstConsoleApp.Practice
{
    class Car
    {
        public string Model {get; set;} = string.Empty;
        public string Color {get; set;} = string.Empty;

        public Car()
        {
        }
        public void Display()
        {
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Color : {Color}");
        }

        public Car(string model, string color)
        {
            Model = model;
            Color = color;
        }
    }

    class Maruthi : Car
    {
        public string EngineType {get; set;} = string.Empty;

        public Maruthi() : base()
        {
            
        }
        public Maruthi(string model, string color, string engineType) : base(model, color)
        {
            EngineType = engineType;
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine($"Engine Type : {EngineType}");
        }
    }
    
    class ObjectInitialising
    {
        public static void Run()
        {
            Maruthi car1 = new Maruthi()
            {
                Model = "Swift",
                Color = "Red",
                EngineType = "Petrol"
            };

            Maruthi car2 = new Maruthi();
            car2.Model = "dzire";
            car2.Color = "blue";
            car2.EngineType = "diesel";

            Maruthi car3 = new Maruthi("Baleno", "White", "CNG");

            car1.Display();
            Console.WriteLine();
            car2.Display();
            Console.WriteLine();
            car3.Display();
            Console.WriteLine();

        }
    }

}
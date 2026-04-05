using System;
namespace MyFirstConsoleApp.Practice
{
    class Animal
    {
        // public string Name { get; set; } = "";
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
    }

    class Dog : Animal
    {
        public string Breed { get; set; } = "";

        public void Bark()
        {
            Console.WriteLine($"{Name} is barking: Woof! Woof!");
        }
    }

    class Cat : Animal
    {
        public string Color { get; set; } = "";

        public void Meow()
        {
            Console.WriteLine($"{Name} is meowing: Meow!");
        }
    }

    class Inheritence
    {
        public static void Run()
        {

            // Dog dog = new Dog();
            // dog.Name = "Buddy";
            // dog.Age = 3;
            // dog.Breed = "Golden Retriever";
            Dog dog = new Dog()
            {
                Name = "Buddy",
                Age = 3,
                Breed = "Golden Retriever"
            };

            Console.WriteLine($"Dog Name: {dog.Name}");
            Console.WriteLine($"Age: {dog.Age}");
            Console.WriteLine($"Breed: {dog.Breed}");
            dog.Eat();   
            dog.Sleep(); 
            dog.Bark(); 

            Console.WriteLine();

            Cat cat = new Cat();
            cat.Name = "pinkey";
            cat.Age = 2;
            cat.Color = "Orange";

            Console.WriteLine($"Cat Name: {cat.Name}");
            Console.WriteLine($"Age: {cat.Age}");
            Console.WriteLine($"Color: {cat.Color}");
            cat.Eat();    
            cat.Sleep();  
            cat.Meow(); 
        }
    }
}

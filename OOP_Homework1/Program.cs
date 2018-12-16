using System;

namespace OOP_Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Platypus platybus = new Platypus();
            platybus.Hey();
            platybus.Swim();
            platybus.Walk();
            platybus.MaxWalkingSpeed = 15;
            platybus.MaxSwimmingSpeed = 20;
            Console.WriteLine("My maximum walking speed is: " + platybus.MaxWalkingSpeed + " km/h. " +
                "\nMy maximum swimming speed is: " + platybus.MaxSwimmingSpeed + " km/h.");

            Console.WriteLine();

            Salmon salmon = new Salmon();
            salmon.Hello();
            salmon.Swim();
            salmon.MaxSwimmingSpeed = 20;
            Console.WriteLine("My maximum swimming speed is: " + salmon.MaxSwimmingSpeed + " km/h.");

            Console.WriteLine();

            WildDuck duck = new WildDuck();
            duck.Hola();
            duck.Swim();
            duck.Walk();
            duck.Fly();
            duck.MaxFlyingSpeed = 100;
            duck.MaxSwimmingSpeed = 5;
            duck.MaxWalkingSpeed = 7;
            Console.WriteLine("My maximum flying speed is " + duck.MaxFlyingSpeed + " km/h." +
                "\nMy maximum swimming speed is " + duck.MaxSwimmingSpeed + " km/h." + "\nMy maximum walking speed is " +
                duck.MaxWalkingSpeed + " km/h.");

            Console.WriteLine();

            Snake snake = new Snake();
            snake.Hi();
            snake.Swim();
            snake.Crawl();
            snake.MaxSpeed = 20;
            snake.MaxSwimmingSpeed = 35;
            Console.WriteLine("My maximum crawling speed is: " + snake.MaxSpeed + " km/h." + 
                "\nMy maximum swimming speed is: " + snake.MaxSwimmingSpeed + " km/h.");

            Console.WriteLine();

            LadyBug ladybug = new LadyBug();           
            ladybug.MaxFlyingSpeed = 50;
            ladybug.MaxWalkingSpeed = 1;
            ladybug.Name = "Ladybug";
            string output;
            output = ladybug.ToString();
            Console.WriteLine(output);
            ladybug.Fly();

        }
    }
       
}

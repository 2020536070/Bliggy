/* CSIS2664
 * Bridge pattern example
 * Wikipedia: The bridge pattern is useful when both the class and what it does, vary often.
 *            The class itself can be thought of as the abstraction and what the class can do as the implementation. 
 * Scenario       : An animal moves
 * Abstraction    : The animal
 * Implementation : Movement
 * P Blignaut 2021
*/

using System;

class Client
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine();

        //Concrete implementations
        IMovement walk = new Walk();
        IMovement run = new Run();

        //Abstractions with properties
        AAnimal cat1 = new Cat("Daisy", "White");
        AAnimal cat2 = new Cat("Luna", "Black");
        AAnimal dog1 = new Dog("Max", "Dalmation");
        AAnimal dog2 = new Dog("Milo", "Labrador");

        //Let the animals move
        cat1.Movement = walk; Console.WriteLine("\t" + cat1);
        cat2.Movement = run;  Console.WriteLine("\t" + cat2);
        dog1.Movement = walk; Console.WriteLine("\t" + dog1);
        dog1.Movement = run;  Console.WriteLine("\t" + dog1);
        dog2.Movement = walk; Console.WriteLine("\t" + dog2);

        //Wait for user
        Console.Write("\n\tPress any key to exit ...");
        Console.ReadKey();
    } //Main
}


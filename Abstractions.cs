//2079034130

using System.Drawing;

class Dog : AAnimal
{
    public string Breed { get; private set; }

    public Dog(string name, string breed) : base (name)
    {
        this.Breed = breed;
    } //ctor

    public override string ToString()
    {
        return Name + " is a " + Breed + " and " + Moves() + ".";
    }

} //class Dog

class Cat : AAnimal
{
    public string Colour { get; private set; }
    public Cat(string name, string colour) : base(name)
    {
        this.Colour = colour;
    } //ctor

    public override string ToString()
    {
        return Name + " is " + Colour + " and " + Moves() + ".";
    }
} //class Cat
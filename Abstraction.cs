//2079034130

public abstract class AAnimal
{
    public string Name { get; private set; }

    //Instance of implementation - the bridge
    public IMovement Movement { get; set; }

    //Constructor
    public AAnimal(string name)
    {
        this.Name = name;
    } //Constructor

    public string Moves()
    {
        return Movement.Move(this);
    } //Move

} //class Animal


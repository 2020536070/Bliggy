//2079034130

public class Walk : IMovement
{
    public string Move(AAnimal animal)
    {
        return "walks";
    }
} //Walk

public class Run : IMovement
{
    public string Move(AAnimal animal)
    {
        return "runs";
    }
} //Run




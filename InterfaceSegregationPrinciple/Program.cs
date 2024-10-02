// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Human human = new Human();
human.Eat();
human.Work();

Robot robot = new Robot();
robot.Work();

public interface IEatable
{
    void Eat();
}

public interface IWorkable
{
    void Work();
}

public class Human : IWorkable, IEatable
{
    public void Work()
    {
        Console.WriteLine("Kerja nih");
    }

    public void Eat() 
    { 
        Console.WriteLine("Makan nih"); 
    }
}

public class Robot : IWorkable
{
    public void Work()
    {
        Console.WriteLine("Kerja nih");
    }
}
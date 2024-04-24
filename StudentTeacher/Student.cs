public class Student
{
    public string Name { get; set; }

    public Student(string name)
    {
        Name = name;
    }

    public void GoSilent()
    {
        Console.WriteLine($"{Name} goes silent");
    }
    public void MakeNoise()
    {
        Console.WriteLine($"{Name} makes noise");
    }

}
public class StudentAction
{
    private Student[] students;

    public StudentAction()
    {
        try{
        string[] studentNames = File.ReadAllLines("students.txt");
        students = new Student[studentNames.Length];

        for(int i = 0; i < studentNames.Length; i++)
        {
            students[i] = new Student(studentNames[i]);
        }
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("File Not Found!");
        }
    }
    public void GoSilent()
    {
        foreach(Student student in students)
        {
            student.GoSilent();
        }
    }

    public void MakeNoise()
    {
        foreach(Student student in students)
        {
            student.MakeNoise();
        }
    }
}
public class StudentRepository
{
    public Student[] GetAll()
    {
        try
        {
            string[] studentNames = File.ReadAllLines("students.txt");
            Student[] students = new Student[studentNames.Length];

            for (int i = 0; i < studentNames.Length; i++)
            {
                students[i] = new Student(studentNames[i]);
            }

            return students;
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File Not Found!");
            return new Student[0]; // Return an empty array if the file is not found
        }
    }
}

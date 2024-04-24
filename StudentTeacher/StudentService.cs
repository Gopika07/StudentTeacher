public class StudentService
{
    private Student[] students;
    private StudentRepository studentRepository;

    public StudentService(StudentRepository studentRepository)
    {
        this.studentRepository = studentRepository;
        this.students = studentRepository.GetAll();
    }

    public void MakeNoiseAll()
    {
        foreach (Student student in students)
        {
            student.MakeNoise();
        }
    }

    public void GoSilentAll()
    {
        foreach (Student student in students)
        {
            student.GoSilent();
        }
    }
}

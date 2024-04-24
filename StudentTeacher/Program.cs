class Program
{
    static void Main(string[] args)
    {
        Teacher teacher = new Teacher();
         StudentRepository studentRepo = new StudentRepository();
        StudentService student = new StudentService(studentRepo);

        bool teacherInClass = true;
        var resp = "";

        do
        {
            Console.WriteLine("\nEnter T to toggle");
            Console.WriteLine("Enter E to exit");
            resp = Console.ReadLine();

            if(resp == "T" || resp == "t")
            {
                if(teacherInClass)
                {
                    teacher.GetIntoClass();
                    student.GoSilentAll();
                }
                else
                {
                    teacher.GetOutOfClass();
                    student.MakeNoiseAll();
                }
                teacherInClass = !teacherInClass;
            }
            else
            {
                Console.WriteLine("Enter a valid input");
            }
        }while(resp.ToUpper() != "E");
    }
}
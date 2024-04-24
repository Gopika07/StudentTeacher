class Program
{
    static void Main(string[] args)
    {
        Teacher teacher = new Teacher();
         StudentRepository studentRepo = new StudentRepository();
        StudentService students = new StudentService(studentRepo);

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
                    students.GoSilentAll();
                }
                else
                {
                    teacher.GetOutOfClass();
                    students.MakeNoiseAll();
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
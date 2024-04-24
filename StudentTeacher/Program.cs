class Program
{
    static void Main(string[] args)
    {
        Teacher teacher = new Teacher();
        StudentAction student = new StudentAction();

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
                    student.GoSilent();
                }
                else
                {
                    teacher.GetOutOfClass();
                    student.MakeNoise();
                }
                teacherInClass = !teacherInClass;
            }
        }while(resp != "E");
    }
}
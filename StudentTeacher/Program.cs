using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddSingleton(new Teacher());
        services.AddSingleton(new StudentRepository());
        services.AddSingleton<StudentService>();
        services.AddMediatR(c =>
        {
            c.RegisterServicesFromAssembly(typeof(Program).Assembly);
        });

        var serviceProvider = services.BuildServiceProvider();

        Teacher teacher = serviceProvider.GetRequiredService<Teacher>();
        StudentService students = serviceProvider.GetRequiredService<StudentService>();

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
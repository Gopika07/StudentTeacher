using Microsoft.Extensions.DependencyInjection;
using StudentTeacher;

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
        services.AddTransient<ITeacherStudentInteraction, TeacherStudentInteraction>();

        var serviceProvider = services.BuildServiceProvider();

        var interaction = serviceProvider.GetRequiredService<ITeacherStudentInteraction>();

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
                    interaction.TeacherJoinsStudentsInClass();
                }
                else
                {
                    interaction.TeacherLeavesClassroom();
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
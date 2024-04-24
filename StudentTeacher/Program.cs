using MediatR;
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

        var eventPublisher = serviceProvider.GetRequiredService<IMediator>();

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
                    eventPublisher.Publish(new TeacherJoinsClass());
                }
                else
                {
                    eventPublisher.Publish(new TeacherLeavesClass());
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
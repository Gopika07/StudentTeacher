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
        services.AddSingleton<ToggleState>();

        var serviceProvider = services.BuildServiceProvider();

        var state = serviceProvider.GetRequiredService<ToggleState>();
        
        var resp = "";

        do
        {
            Console.WriteLine("\nEnter T to toggle");
            Console.WriteLine("Enter E to exit");
            resp = Console.ReadLine();

            if(resp is "T" or "t")
            {
                state.Toggle();
            }
            else
            {
                Console.WriteLine("Enter a valid input");
            }
        }while(resp.ToUpper() != "E");
    }
}
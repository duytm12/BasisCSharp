using Microsoft.Extensions.Configuration;
 
namespace ConsoleAppProject;

public class Application
{
    private readonly IConfiguration _configuration;

    public Application(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    private void NotUsed()
    {
        //_menu = new MainMenu();
        //_configuration = configuration;

        //var itWorks = _configuration["Test:Setting1"];
        //Console.WriteLine($"Configuration Test in Application: ItWorks = {itWorks}");
    }

    public Task DoWork()

    {
        Console.WriteLine("Welcome to the 99 Bottles of Learning To Code Application!\n");

        for (int i = 99; i > 0; i--)
        {
            Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer.");
            Console.WriteLine($"Take one down, pass it around, {i - 1} bottles of beer on the wall.\n");
        }


        
        Console.WriteLine("Thank you for using the 99 Bottles of Learning To Code Application!");
        
        return Task.CompletedTask;
    }
}


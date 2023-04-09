using UserRegistrationProblem;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome To User Validation Program!");
        Validation validation = new Validation();
        validation.ValidateFirstName("Amol");
        validation.ValidateFirstName("Ku");
        validation.ValidateFirstName("Jai");
        validation.ValidateFirstName("Sam");
    }
}
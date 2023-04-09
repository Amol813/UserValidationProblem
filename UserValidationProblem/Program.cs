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
  
        validation.ValidateSecondName("Amol");
        validation.ValidateSecondName("Ku");
        validation.ValidateSecondName("Jai");
        validation.ValidateSecondName("Sam");

        
        validation.ValidateEmail("Amol.xyz@bridgelabz.co.in");
        validation.ValidateEmail("Ku@gmail.com");
        validation.ValidateEmail("sai123@gmail");
    }
}

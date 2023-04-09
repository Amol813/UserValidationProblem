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

        validation.ValidateMobileNumber("9643840561");
        validation.ValidateMobileNumber("012346");

        validation.ValidatePassword("abc@123yj");
        validation.ValidatePassword("000456ABC");
        validation.ValidatePassword("123@067");

        validation.ValidatePassword("abc@123yj");
        validation.ValidatePassword("000456ABC");
        validation.ValidatePassword("123@067");

        validation.ValidatePassword("abc@_123yj");
        validation.ValidatePassword("000_456ABC");
        validation.ValidatePassword("Amol@067");
    }
}

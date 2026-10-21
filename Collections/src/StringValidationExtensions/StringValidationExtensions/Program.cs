namespace StringValidationExtensions;

class Program
{
    public static void Main(string[] args)
    {
        bool IsTruePhoneNumber = "01012345678".IsValidEgyptianPhone();
        bool IsTruenationalID = "2990101123456".IsValidEgyptianNationalId();
        Console.WriteLine($"Phone Number: {IsTruePhoneNumber}\nNational ID: {IsTruenationalID}");
    }
}
namespace RefactoringLab;

public class Program
{
    public static void Main(string[] args)
    {
        /*
        var shipping = new ShippingCostCalculator();
        Console.WriteLine($"Aramex 2kg > {shipping.Calculate(new Aramex(), 2)}");
        Console.WriteLine($"FedEx 2kg  > {shipping.Calculate(new FedEx(), 2)}");
        Console.WriteLine();
        */

        /*
        var processor = new OrderProcessor();
        processor.Process(1001, "customer@example.com");
        Console.WriteLine();
        */

        /*
        new UrgentScheduledEmailNotification { SendAt = DateTime.Today.AddHours(18) }
            .Send("customer@example.com", "Your order ships tomorrow");
        new UrgentSmsNotification()
            .Send("+201000000000", "OTP 4821");
        */

        NotificationRequest Request = new NotificationRequest(
            to: "Yousef@gmail.com",
            message: "Hello",
            urgent: true,
            sendAt: DateTime.Today.AddHours(18)
            );

        EmailNotification Channel = new EmailNotification();

        new NotificationManager(Channel).Send(Request);
    }
}

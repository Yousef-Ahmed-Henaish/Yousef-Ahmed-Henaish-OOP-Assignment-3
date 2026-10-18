namespace RefactoringLab;

public class Program
{
    public static void Main(string[] args)
    {

        var shipping = new ShippingCostCalculator();
        Console.WriteLine($"Aramex 2kg => {shipping.Calculate(new Aramex(), 2)}");
        Console.WriteLine($"FedEx 2kg  => {shipping.Calculate(new FedEx(), 2)}");
        Console.WriteLine();

        OrderProcessor Order = new OrderProcessor( new SqlOrderRepository(), new SmtpEmailSender() );
        Order.Process(1001, "customer@exmple.com");
        Console.WriteLine();

        NotificationRequest Request = new NotificationRequest(
            to: "Yousef@gmail.com",
            message: "Hello",
            urgent: true,
            sendAt: DateTime.Today.AddHours(50)
            );

        EmailNotification Channel = new EmailNotification();

        new NotificationManager(Channel).Send(Request);
        Console.WriteLine();


        //================================================ New Channels ================================================
        Console.WriteLine("================= New Channels =================");

        NotificationRequest Request2 = new NotificationRequest(
            to: "01000000000",
            message: "Hello",
            urgent: true
            );

        WhatsappNotification Channel2 = new WhatsappNotification();

        new NotificationManager(Channel2).Send(Request2);

        Console.WriteLine($"Bosta 5kg => {shipping.Calculate(new Bosta(), 5)}");

    }
}

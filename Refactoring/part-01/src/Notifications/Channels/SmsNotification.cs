namespace RefactoringLab;

public class SmsNotification : INotificationChannel
{
    public void Send(NotificationRequest request)
    {
        if (request.Urgent && request.SendAt.HasValue)
            Console.WriteLine($"[Sms scheduled {request.SendAt:g}] {request.To}: [URGENT] {request.Message}");

        else if (request.Urgent)
            Console.WriteLine($"Sending Sms to {request.To}: [URGENT] {request.Message}");


        else if (request.SendAt.HasValue)
            Console.WriteLine($"[Sms scheduled {request.SendAt:g}] {request.To}: {request.Message}");

        else
            Console.WriteLine($"Sending Sms to {request.To}: {request.Message}");
    }
}

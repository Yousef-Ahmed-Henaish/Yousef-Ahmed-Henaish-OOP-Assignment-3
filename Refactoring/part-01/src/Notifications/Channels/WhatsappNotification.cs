namespace RefactoringLab;

public class WhatsappNotification : INotificationChannel
{
    public void Send(NotificationRequest request)
    {
        if (request.Urgent && request.SendAt.HasValue)
            Console.WriteLine($"[whatsapp scheduled {request.SendAt:g}] {request.To}: [URGENT] {request.Message}");

        else if (request.Urgent)
            Console.WriteLine($"Sending whatsapp to {request.To}: [URGENT] {request.Message}");

        else if (request.SendAt.HasValue)
            Console.WriteLine($"[whatsapp scheduled {request.SendAt:g}] {request.To}: {request.Message}");

        else
            Console.WriteLine($"Sending whatsapp to {request.To}: {request.Message}");
    }
}

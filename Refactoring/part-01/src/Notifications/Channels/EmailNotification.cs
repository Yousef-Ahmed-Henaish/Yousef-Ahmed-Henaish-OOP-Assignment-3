namespace RefactoringLab;

public class EmailNotification : INotificationChannel
{
    public void Send(NotificationRequest request)
    {
        if (request.Urgent && request.SendAt.HasValue)
            Console.WriteLine($"[email scheduled {request.SendAt:g}] {request.To}: [URGENT] {request.Message}");

        else if (request.Urgent)
            Console.WriteLine(request.To, $"[URGENT] {request.Message}");

        else if (request.SendAt.HasValue)
            Console.WriteLine($"[email scheduled {request.SendAt:g}] {request.To}: {request.Message}");

        else
            Console.WriteLine($"Sending email to {request.To}: {request.Message}"); 
    }
}

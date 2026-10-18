namespace RefactoringLab;

public class EmailNotification : INotificationChannel
{
    public void Send(NotificationRequest request)
    {
        if (request.Urgent && request.SendAt.HasValue)
            Console.WriteLine($"[Email scheduled {request.SendAt:g}] {request.To}: [URGENT] {request.Message}");

        else if (request.Urgent)
            Console.WriteLine($"Sending Email to {request.To}: [URGENT] {request.Message}");


        else if (request.SendAt.HasValue)
            Console.WriteLine($"[Email scheduled {request.SendAt:g}] {request.To}: {request.Message}");

        else
            Console.WriteLine($"Sending Email to {request.To}: {request.Message}"); 
    }
}

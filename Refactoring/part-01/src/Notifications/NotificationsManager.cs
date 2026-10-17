namespace RefactoringLab;

public class NotificationManager
{
    private readonly INotificationChannel Channel;
    
    public NotificationManager(INotificationChannel channel)
    {
        Channel = channel;
    }

    public void Send(NotificationRequest request)
    {
            Channel.Send(request);
    }

}
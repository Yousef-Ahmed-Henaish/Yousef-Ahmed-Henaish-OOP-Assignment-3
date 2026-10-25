namespace RefactoringLab;

public interface INotificationChannel
{
    public void Send(NotificationRequest request);
}
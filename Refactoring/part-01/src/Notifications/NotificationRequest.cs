namespace RefactoringLab;

public record NotificationRequest
{
    public NotificationRequest(string to, string message, bool urgent = false, DateTime? sendAt = null )
    {
        To = to;
        Message = message;
        Urgent = urgent;
        
        /*Should not found because this is only refactoring, but it's right logically*/
        if (sendAt < DateTime.Now)
            throw new ArgumentException("Date Can't be in the past !");
        else
            SendAt = sendAt;
    }

    public string To {get; init;}
    public string Message {get; init;}
    public bool Urgent {get; init;}
    public DateTime? SendAt {get; init;}
}

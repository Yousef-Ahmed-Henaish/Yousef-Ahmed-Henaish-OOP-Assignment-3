namespace RefactoringLab;
public interface ISmtpSender
{
    public void Send(string to, string body);
}
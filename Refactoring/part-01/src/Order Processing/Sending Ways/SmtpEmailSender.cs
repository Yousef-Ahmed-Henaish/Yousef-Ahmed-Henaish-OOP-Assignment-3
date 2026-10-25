namespace RefactoringLab;

public class SmtpEmailSender : ISmtpSender
{
    public void Send(string to, string body) =>
        Console.WriteLine($"[SMTP] to: {to} body: {body}");
}
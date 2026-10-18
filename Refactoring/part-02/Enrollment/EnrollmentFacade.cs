namespace RefactoringLab.Part02.Enrollment;

public class EnrollmentFacade
{
    private readonly PaymentGateway _payment;
    private readonly SeatInventory _seats;
    private readonly InvoiceGenerator _invoice;
    private readonly EmailService _email;

    public EnrollmentFacade(PaymentGateway paymentGatway, SeatInventory seatInventory, InvoiceGenerator invoiceGenerator, EmailService emailService)
    {
        _payment = paymentGatway;
        _seats = seatInventory;
        _invoice = invoiceGenerator;
        _email = emailService;
    }
    
    public void Enroll(string studentId, string courseId, decimal amount)
    {
        Charge(studentId, amount);
        ReserveSeat( courseId, studentId);
        var invoiceId = CreateInvoice(studentId, amount);
        SendEmail(studentId, "Enrollment confirmed", $"Invoice {invoiceId} for {courseId}");
    }

    public void Charge(string studentId, decimal amount)
    {
        _payment.Charge(studentId, amount);
    }

    public void ReserveSeat(string courseId, string studentId)
    {
        _seats.Reserve(courseId, studentId);
    }

    public void SendEmail(string studentId, string subject, string body)
    {
        _email.Send(studentId, subject, body);
    }

    public string CreateInvoice(string studentId, decimal amount)
    {
        return _invoice.Create(studentId, amount);
    }
}

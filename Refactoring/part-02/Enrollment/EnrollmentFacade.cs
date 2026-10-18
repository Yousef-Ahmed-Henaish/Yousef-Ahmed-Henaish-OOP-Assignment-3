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
        _payment.Charge(studentId, amount);
        _seats.Reserve(courseId, studentId);
        var invoiceId = _invoice.Create(studentId, amount);
        _email.Send(studentId, "Enrollment confirmed", $"Invoice {invoiceId} for {courseId}");
    }
}

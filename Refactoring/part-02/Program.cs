using RefactoringLab.Part02.Enrollment;
using RefactoringLab.Part02.Reports;
using RefactoringLab.Part02.Reports.Exporters;

Console.WriteLine("=== Reports ===");
var outDir = Path.Combine(Path.GetTempPath(), "refactoring-lab-part02");
Directory.CreateDirectory(outDir);

new CsvReportExporter().Export(Path.Combine(outDir, "report.csv"));
new JsonReportExporter().Export(Path.Combine(outDir, "report.json"));
new TextReportExporter().Export(Path.Combine(outDir, "report.txt"));
Console.WriteLine($"Wrote reports to {outDir}");
Console.WriteLine();

Console.WriteLine("=== Enrollment ===");
var studentId = "S100";
var courseId = "CS201";
var amount = 1500m;

EnrollmentFacade Enroll = new EnrollmentFacade(new PaymentGateway(), new SeatInventory(), new InvoiceGenerator(), new EmailService());

Enroll.Enroll(studentId, courseId, amount);

/*
Enroll.Charge(studentId, amount);

Enroll.ReserveSeat(courseId, studentId);

var invoiceId = Enroll.CreateInvoice(studentId, amount);

Enroll.SendEmail(studentId, "Enrollment confirmed", $"Invoice {invoiceId} for {courseId}");
*/
namespace RefactoringLab;
public class OrderProcessor
{
    private readonly IOrderRepository _orderRepo;
    private readonly ISmtpSender _sender;

    public OrderProcessor(IOrderRepository orderRepo, ISmtpSender sender)
    {
        _orderRepo = orderRepo;
        _sender = sender;
    }

    public void Process(int orderId, string to)
    {
        _orderRepo.Save(orderId, DateTime.Now);
        _sender.Send(to, $"Order {orderId} confirmed at {DateTime.Now}");
    }
}
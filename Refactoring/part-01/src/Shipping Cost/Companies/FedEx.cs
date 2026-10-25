namespace RefactoringLab;

public class FedEx : IShippingCalculator
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 15m;
    }
}


namespace RefactoringLab;

public class DHL : IShippingCalculator
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 18m;
    }
}


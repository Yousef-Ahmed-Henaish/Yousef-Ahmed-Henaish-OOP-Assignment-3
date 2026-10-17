namespace RefactoringLab;

public class Aramex : IShippingCalculator
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 12m;
    }
}


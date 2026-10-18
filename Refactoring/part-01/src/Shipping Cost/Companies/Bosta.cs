namespace RefactoringLab;

public class Bosta : IShippingCalculator
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 13m;
    }
}


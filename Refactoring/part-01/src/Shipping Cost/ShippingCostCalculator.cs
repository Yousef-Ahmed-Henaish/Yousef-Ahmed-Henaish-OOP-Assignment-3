namespace RefactoringLab;

public class ShippingCostCalculator
{
    public decimal Calculate(IShippingCalculator carrier, decimal weightKg)
    {
        return carrier.Calculate(weightKg);
    }
}

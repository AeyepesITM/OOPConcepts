namespace OOPConcepts.Logic;

public class CommisionEmployee : Employee
{
    #region Atribute

    private float _commisionPercentage;
    private decimal _sales;

    #endregion Atribute

    #region Properties

    public float CommisionPercentage
    {
        get => _commisionPercentage;
        set => _commisionPercentage = ValidateCommisionPercentage(value);
    }

    public decimal Sales
    {
        get => _sales;
        set => _sales = ValidateSales(value);
    }

    #endregion Properties

    #region Methods

    public override decimal GetValueToPay()
    {
        return Sales * (decimal)CommisionPercentage * 0.88m;
    }

    public override string ToString()
    {
        return $"{base.ToString()}" +
               $"Commision %...:{CommisionPercentage,20:P2} \n\t" +
               $"Sales.........:{Sales,20:C2} \n\t" +
               $"Value to pay..:{GetValueToPay(),20:C2} \n\t";
    }

    private decimal ValidateSales(decimal value)
    {
        if (value < 0)
        {
            throw new ArgumentException("The sales is not valid. It must be greater than 0.");
        }
        return value;
    }

    private float ValidateCommisionPercentage(float value)
    {
        if (value < 0 || value > 1)
        {
            throw new ArgumentException("The commision percentage is not valid. It must be between 0 and 1.");
        }
        return value;
    }

    #endregion Methods
}
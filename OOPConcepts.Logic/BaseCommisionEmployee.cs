namespace OOPConcepts.Logic;

public class BaseCommisionEmployee : CommisionEmployee
{
    #region Atribute

    private decimal _salary;

    #endregion Atribute

    #region Properties

    public decimal Salary
    {
        get => _salary;
        set => _salary = ValidateSalary(value);

        #endregion Properties
    }

    #region Methods

    public override decimal GetValueToPay()
    {
        var salary = base.GetValueToPay() + Salary;

        if (salary < 1350000)
        {
            return 1350000m;
        }
        return base.GetValueToPay() + Salary;
    }

    public override string ToString()
    {
        return $"{Id}\t{FirstName} {LastName}\n\t" +
               $"Hired.........:{HireDate} \n\t" +
               $"Commision %...:{CommisionPercentage,20:P2} \n\t" +
               $"Base salary...:{Salary,20:C2} \n\t" +
               $"Sales.........:{Sales,20:C2} \n\t" +
               $"Value to pay..:{GetValueToPay(),20:C2} \n\t";
    }

    private decimal ValidateSalary(decimal value)
    {
        if (value < 600000)
        {
            throw new ArgumentException("The salary base is not valid.");
        }
        return value;
    }

    #endregion Methods
}
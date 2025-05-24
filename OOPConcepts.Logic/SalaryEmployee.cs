namespace OOPConcepts.Logic;

public class SalaryEmployee : Employee
{
    #region Atribute

    private decimal _salary;

    #endregion Atribute

    #region Properties

    public decimal Salary
    {
        get => _salary;
        set => _salary = ValidateSalary(value);
    }

    #endregion Properties

    #region Methods

    public override decimal GetValueToPay()
    {
        return Salary * 0.88m;
    }

    public override string ToString()
    {
        return $"{base.ToString()}" +
               $"Salary........:{Salary,20:C2} \n\t" +
               $"Value to pay..:{GetValueToPay(),20:C2} \n\t";
    }

    private decimal ValidateSalary(decimal value)
    {
        if (value < 1350000)
        {
            throw new ArgumentException("The salary is less that minimun.");
        }
        return value;
    }

    #endregion Methods
}
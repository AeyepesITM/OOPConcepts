namespace OOPConcepts.Logic;

public class HourlyEmployee : Employee
{
    #region Atribute

    private float _workingHours;
    private decimal _hourvalue;

    #endregion Atribute

    #region Properties

    public float WorkingHours
    {
        get => _workingHours;
        set => _workingHours = ValidateWorkingHours(value);
    }

    public decimal HourValue
    {
        get => _hourvalue;
        set => _hourvalue = ValidateHourValue(value);
    }

    #endregion Properties

    #region Methods

    public override decimal GetValueToPay()
    {
        return (decimal)WorkingHours * HourValue * 0.88m;
    }

    public override string ToString()
    {
        return $"{base.ToString()}" +
               $"Working Hours.:{WorkingHours,20:N2} \n\t" +
               $"Hour Value....:{HourValue,20:C2} \n\t" +
               $"Value to pay..:{GetValueToPay(),20:C2} \n\t";
    }

    private float ValidateWorkingHours(float value)
    {
        if (value < 0 || value > 240)
        {
            throw new ArgumentException("The working hours is not valid. It must be between 0 and 240.");
        }
        return value;
    }

    private decimal ValidateHourValue(decimal value)
    {
        if (value < 30000)
        {
            throw new ArgumentException("The hour value is not valid. It must be greater than 30,000.");
        }
        return value;
    }

    #endregion Methods
}
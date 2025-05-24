namespace OOPConcepts.Logic;

public class Date
{
    #region Attributes

    private int _year;
    private int _month;
    private int _day;

    #endregion Attributes

    #region Constructors

    public Date(int year, int month, int day)
    {
        _year = ValidateYear(year);
        _month = ValidateMonth(month);
        _day = ValidateDay(day);
    }

    public Date()
    {
        _year = 1900;
        _month = 1;
        _day = 1;
    }

    #endregion Constructors

    #region Properties

    public int Year
    {
        get => _year;
        set => _year = ValidateYear(value);
    }

    public int Month
    {
        get => _month;
        set => _month = ValidateMonth(value);
    }

    public int Day
    {
        get => _day;
        set => _day = ValidateDay(value);
    }

    #endregion Properties

    #region Methods Publics

    public override string ToString()
    {
        return $"{Year,4:0000}/{Month,2:00}/{Day,2:00}";
    }

    #endregion Methods Publics

    #region Methods Privates

    private int ValidateYear(int year)
    {
        if (year < 0)
        {
            throw new ArgumentException("The year is not valid.");
        }
        return year;
    }

    private int ValidateMonth(int month)
    {
        if (month < 1 || month > 12)
        {
            throw new ArgumentException("The month is not valid.");
        }
        return month;
    }

    private int ValidateDay(int day)
    {
        // Validación para el 29 de febrero en un año bisiesto
        if (day == 29 && _month == 2 && IsLeapYear(_year))
        {
            return day;  // Si es un año bisiesto, el 29 de febrero es válido
        }

        // Validación para los días en los meses que no tienen 31 días
        if (day > 31 ||
            day < 1 ||
            (day > 30 &&
            (_month == 4 || _month == 6 || _month == 9 || _month == 11)
            ) ||
            (day > 28 && _month == 2 && !IsLeapYear(_year)))
        {
            throw new ArgumentException("The day is not valid.");
        }

        return day;  // Si pasa todas las validaciones, devuelve el día
    }

    private bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    #endregion Methods Privates
}
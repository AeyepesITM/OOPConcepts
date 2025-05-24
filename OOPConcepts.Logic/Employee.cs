namespace OOPConcepts.Logic;

#region Class Employee

public abstract class Employee : IPay
{
    #region Properties

    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public Date? BornDate { get; set; }
    public Date? HireDate { get; set; }
    public bool IsActive { get; set; }

    #endregion Properties

    #region Methods

    public override string ToString()
    {
        return $"{Id}\t{FirstName} {LastName}\n\t" +
                $"Hired.........:{HireDate} \n\t";
    }

    public abstract decimal GetValueToPay();

    #endregion Methods
}

#endregion Class Employee
namespace OOPConcepts.Logic;

public class Invoice : IPay

{
    #region Properties

    public int Id
    {
        get;
        set;
    }

    public string? Description
    {
        get;
        set;
    }

    public float Quantity
    {
        get;
        set;
    }

    public decimal Price
    {
        get;
        set;
    }

    #endregion Properties

    #region Methods

    public decimal GetValueToPay()
    {
        return Price * (decimal)Quantity;
    }

    public override string ToString()
    {
        return $"{Id}\t{Description} \n\t" +
               $"Quantity......:{Quantity,20:N2} \n\t" +
               $"Price.........:{Price,20:C2} \n\t" +
               $"Value to pay..:{GetValueToPay(),20:C2} \n\t";
    }

    #endregion Methods
}
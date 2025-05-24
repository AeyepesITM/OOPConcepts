using OOPConcepts.Logic;

try
{
    var date1 = new Date() { Year = 2025, Month = 05, Day = 23 };
    var date2 = new Date(2024, 2, 29);
    var date3 = new Date
    {
        Year = 1895,
        Month = 11,
        Day = 1
    };
    //Ultima interfaz
    date1.Year = date2.Year + 20;
    date1.Month = date3.Month + 1;
    date1.Day = 15;
    Console.WriteLine($"Date 1: {date1}");
    Console.WriteLine($"Date 2: {date2}");
    Console.WriteLine($"Date 3: {date3}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
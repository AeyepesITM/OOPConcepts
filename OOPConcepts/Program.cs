﻿using OOPConcepts.Logic;

try
{
    var employeeSalary1 = new SalaryEmployee
    {
        Id = 1010,
        FirstName = "John",
        LastName = "Doe",
        BornDate = new Date(1990, 5, 15),
        HireDate = new Date(2020, 1, 1),
        IsActive = true,
        Salary = 1600000m
    };
    var employeeWorkHour1 = new HourlyEmployee
    {
        Id = 2020,
        FirstName = "Benjamin",
        LastName = "Button",
        BornDate = new Date(1985, 10, 15),
        HireDate = new Date(2020, 11, 11),
        IsActive = true,
        HourValue = 85000m,
        WorkingHours = 123.5f
    };

    var employeeCommision1 = new CommisionEmployee
    {
        Id = 3030,
        FirstName = "Jazmin",
        LastName = "Cifuentes",
        BornDate = new Date(1995, 10, 15),
        HireDate = new Date(2015, 8, 18),
        IsActive = true,
        CommisionPercentage = 0.05f,
        Sales = 300000000m
    };

    var employeeBaseCommision1 = new BaseCommisionEmployee
    {
        Id = 4040,
        FirstName = "Sara",
        LastName = "Lopez",
        BornDate = new Date(1995, 10, 15),
        HireDate = new Date(2015, 8, 18),
        IsActive = true,
        CommisionPercentage = 0.025f,
        Salary = 620000m,
        Sales = 55000000m
    };

    decimal payRoll = 0m;
    // Array of employees
    Employee[] employees = new Employee[] { employeeSalary1, employeeWorkHour1, employeeCommision1, employeeBaseCommision1 };

    // Displaying the information of each employee
    foreach (var employee in employees)
    {
        Console.WriteLine(employee.ToString());
        payRoll += employee.GetValueToPay();
    }
    Console.WriteLine($"                       ====================");
    Console.WriteLine($"Total payroll: {payRoll,28:C2}\n");

    //Invoice example

    var invoice1 = new Invoice
    {
        Id = 1234,
        Description = "Papel",
        Quantity = 84,
        Price = 12000m
    };
    var invoice2 = new Invoice
    {
        Id = 1235,
        Description = "Lapiz",
        Quantity = 100,
        Price = 2000m
    };
    var invoice3 = new Invoice
    {
        Id = 1236,
        Description = "Cuaderno",
        Quantity = 50,
        Price = 5000m
    };
    var invoice4 = new Invoice
    {
        Id = 1237,
        Description = "Borrador",
        Quantity = 200,
        Price = 1000m
    };

    Invoice[] invoices = [invoice1, invoice2, invoice3, invoice4];
    decimal invoiceTotal = 0m;
    // Displaying the information of each invoice
    foreach (var invoice in invoices)
    {
        Console.WriteLine(invoice);
        invoiceTotal += invoice.GetValueToPay();
    }
    Console.WriteLine($"                       ====================");
    Console.WriteLine($"Total invoice: {invoiceTotal,28:C2}");
    Console.WriteLine($"Total payroll: {payRoll,28:C2}");
    Console.WriteLine($"                       ====================");
    Console.WriteLine($"Total pay....: {payRoll + invoiceTotal,28:C2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
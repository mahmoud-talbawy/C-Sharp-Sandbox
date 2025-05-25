using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
class SalaryManagemt
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Welcome To Salery Managemnt app ");
        int[] exposesSum = new int[5];

        string[] exposes = { "Rent", "Electricity", "Gas", "Internet", "Salaries" };
        double sum = 0;

        for (int i = 0; i < exposes.Length; i++)
        {
            Console.Write("enter price of " + exposes[i]+ " : ");
            exposesSum[i] = int.Parse(Console.ReadLine() ?? string.Empty);
            sum = sum + exposesSum[i];
        };
        Console.WriteLine("Total Price is : "+sum);
        

    }
}

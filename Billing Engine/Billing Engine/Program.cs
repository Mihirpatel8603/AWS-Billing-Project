using BillingEngine.Billing;
using BillingEngine.Models.Billing;
using BillingEngine.Printers;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace BillingEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            BillingService billingService = new BillingService();
            BillPrinter billPrinter = new BillPrinter();

            var monthlyBills = billingService.GenerateMonthlyBills(
               "D:/intenship/Test-cases-enhancment-1/Test cases/input/Customer.csv",
                "D:/intenship/Test-cases-enhancment-1/Test cases/input/AWSResourceTypes.csv",
                "D:/intenship/Test-cases-enhancment-1/Test cases/input/AWSReservedInstanceusage.csv",
                "D:/intenship/Test-cases-enhancment-1/Test cases/input/AWSOnDemandResourceUsage.csv",
                "D:/intenship/Test-cases-enhancment-1/Test cases/input/Region.csv"
            );
            //Console.WriteLine(monthlyBills.Count);
            monthlyBills.ForEach(monthlyBill => billPrinter.PrintBill(monthlyBill, "C:/Users/91820/Desktop/AWS-Billing-Project/Result/"));
        }
    }
}
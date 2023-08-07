using BillingEngine.Billing;
using BillingEngine.Models.Billing;
using BillingEngine.Printers;
using System;

namespace BillingEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            BillingService billingService = new BillingService();
            BillPrinter billPrinter = new BillPrinter();

            var monthlyBills = billingService.GenerateMonthlyBills(
                "C:/Users/91820/source/repos//Test cases/input/Customer.csv",
                "C:/Users/91820/source/repos//Test cases/input/AWSResourceTypes.csv",
                "C:/Users/91820/source/repos//Test cases/input/AWSOnDemandResourceUsage.csv",
                "C:/Users/91820/source/repos//Test cases/input/Region.csv"
            );
            //Console.WriteLine(monthlyBills.Count);
            monthlyBills.ForEach(monthlyBill => billPrinter.PrintBill(monthlyBill, "C:/Users/91820/Desktop/AWS-Billing-Project/Result/"));
        }
    }
}
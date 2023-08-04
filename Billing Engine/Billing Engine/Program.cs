using BillingEngine.Billing;
using BillingEngine.Models;
using BillingEngine.Printers;

namespace BillingEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            BillingService billingService = new BillingService();
            BillPrinter billPrinter = new BillPrinter();


            var monthlyBills = billingService.GenerateMonthlyBills(
                "D:/intenship/Case1/Input/Customer.csv",
                "D:/intenship/Case1/Input/AWSResourceType.csv",
                "D:/intenship/Case1/Input/AWSCustomerUsage.csv",
                "/path/to/region.csv"
            );

            monthlyBills.ForEach(monthlyBill => billPrinter.PrintBill(monthlyBill, "C:/Users/91820/Desktop/result"));
        }
    }
}
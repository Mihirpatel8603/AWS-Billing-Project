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
                "/path/to/customer.csv",
                "/path/to/resource-type.csv",
                "/path/to/resource-usage.csv",
                "/path/to/region.csv"
            );

            monthlyBills.ForEach(monthlyBill => billPrinter.PrintBill(monthlyBill, "path/to/output/dir"));
        }
    }
}
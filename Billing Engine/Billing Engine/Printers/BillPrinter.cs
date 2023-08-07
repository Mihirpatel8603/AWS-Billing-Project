using BillingEngine.Helper;
using BillingEngine.Models.Billing;
using System;
using System.IO;
using System.Text;

namespace BillingEngine.Printers
{
    public class BillPrinter
    {
        public string PrintBill(MonthlyBill monthlyBill, string pathToOutputDir)
        {

            //This method will just print the bill by generating CSV and returns file path of that csv.
            // Print header information like customer name, month, year and then print
            // monthlyBill.GetTotalAmount();
            // monthlyBill.GetTotalDiscount();
            // monthlyBill.GetAmountToBePaid();
            var aggregUsage = monthlyBill.GetAggregatedMonthlyEc2Usages();
            double TotalBillAmount = monthlyBill.GetTotalAmount(aggregUsage);
            if (TotalBillAmount == 0) return null;
            string fileName = monthlyBill.CustomerId + "_" + HelperMethods.GetMonthInitial(monthlyBill.MonthYear.Month) + "-" + monthlyBill.MonthYear.Year;

            var csv = new StringBuilder();
            string csvPath = pathToOutputDir + fileName + ".csv";
            csv.AppendLine(monthlyBill.CustomerName);
            csv.AppendLine(string.Format("Bill for month of {0} {1}", HelperMethods.GetMonthName(monthlyBill.MonthYear.Month), monthlyBill.MonthYear.Year));
            csv.AppendLine(string.Format("Total Amount: ${0}", TotalBillAmount));
            csv.AppendLine(string.Format("Total Discount: ${0}", monthlyBill.GetTotalDiscount()));
            csv.AppendLine(string.Format("Actual Amount: ${0}", TotalBillAmount - monthlyBill.GetTotalDiscount()));
            csv.AppendLine("Region,Resource Type,Total Resources,Total Used Time (HH:mm:ss),Total Billed Time (HH:mm:ss),Total Amount,Discount,Actual Amount");

            //Now print itemized bill
            foreach (var usage in aggregUsage)
            {
                csv.AppendLine(string.Format("{0},{1},{2},{3},{4},${5},${6},${7}",
                    usage.RegionName,
                    usage.ResourceType,
                    usage.TotalResources,
                    HelperMethods.ConvertToHour(usage.TotalUsedTime),
                    HelperMethods.ConvertToHour(usage.TotalBilledTime),
                    Math.Round(usage.TotalAmount, 4),
                    Math.Round(usage.TotalDiscount, 4),
                    Math.Round(usage.GetActualAmountToBePaid(), 4)));
            }
            File.WriteAllText(csvPath, csv.ToString());
            //Return path of generated CSV
            return csvPath;
        }
    }
}
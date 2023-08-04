using System;

namespace BillingEngine.Models.Billing
{
    public class AggregatedMonthlyEc2Usage
    {
        public string ResourceType { get; }
        public int TotalResources { get; }
        
        public TimeSpan TotalBilledTime { get; }
        public TimeSpan TotalUsedTime { get; }
        public TimeSpan TotalDiscountedTime { get; }
        
        public double TotalAmount { get; }
        public double TotalDiscount { get; }

        public AggregatedMonthlyEc2Usage()
        {
           
            TotalDiscount = 0;
            TotalAmount = 0;
            TotalResources = 0;
            TotalBilledTime = TimeSpan.Zero;
            TotalUsedTime = TimeSpan.Zero;
            TotalDiscountedTime = TimeSpan.Zero;
            
            
        }

        public double GetActualAmountToBePaid()
        {

            return TotalAmount - TotalDiscount;
        }
        
    }
}
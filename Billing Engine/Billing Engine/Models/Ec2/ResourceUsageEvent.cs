using System;

namespace BillingEngine.Models.Ec2
{
    public class ResourceUsageEvent
    {
        public DateTime UsedFrom { get; }
        
        public DateTime UsedUntil { get; }

        public int GetBillableHours()
        {
            var usedHours = UsedUntil.Subtract(UsedFrom).TotalHours;
            return Convert.ToInt32(Math.Ceiling(usedHours));
        }
    }
}
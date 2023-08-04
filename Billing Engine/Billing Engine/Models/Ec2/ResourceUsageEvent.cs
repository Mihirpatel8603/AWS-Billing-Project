using System;

namespace BillingEngine.Models.Ec2
{
    public class ResourceUsageEvent
    {
        public DateTime UsedFrom { get; }

        public DateTime UsedUntil { get; }
        public ResourceUsageEvent(DateTime usedFrom, DateTime usedUntil)
        {
            UsedFrom = usedFrom;
            UsedUntil = usedUntil;
        }
        public ResourceUsageEvent() { }




        public int GetBillableHours()
        {
            var usedHours = UsedUntil.Subtract(UsedFrom).TotalHours;
            return Convert.ToInt32(Math.Ceiling(usedHours));
        }

        public TimeSpan GetTotalTime()
        {
            return UsedUntil.Subtract(UsedFrom);
        }
    }
}
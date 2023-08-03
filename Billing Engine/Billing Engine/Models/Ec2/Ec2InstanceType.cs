namespace BillingEngine.Models.Ec2
{
    public class Ec2InstanceType
    {
        public Ec2InstanceType(string ec2InstanceType, double cost)
        {
        }

        public string InstanceType { get; }
        public double CostPerHour { get; }
        public Ec2Region Region { get; }
        public OperatingSystem OperatingSystem { get; }
        public BillingType BillingType { get; }
        public bool IsFreeTierEligible { get; }
    }
}
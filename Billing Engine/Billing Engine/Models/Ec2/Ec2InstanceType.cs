namespace BillingEngine.Models.Ec2
{
    public class Ec2InstanceType
    {

        public string InstanceType { get; }
        public double CostPerHour { get; }
        public Ec2Region Region { get; }
        public OperatingSystem OperatingSystem { get; }
        public BillingType BillingType { get; }
        public bool IsFreeTierEligible { get; }
        public Ec2InstanceType(string ec2InstanceType, double cost)
        {
            this.InstanceType = InstanceType;
            this.CostPerHour = CostPerHour;
            this.Region = new Ec2Region("Asia (Mumbai)");
            this.OperatingSystem = OperatingSystem.Linux;
            this.BillingType = BillingType.OnDemand;
            this.IsFreeTierEligible = false;
        }

        public Ec2InstanceType()
        {
        }
    }
}
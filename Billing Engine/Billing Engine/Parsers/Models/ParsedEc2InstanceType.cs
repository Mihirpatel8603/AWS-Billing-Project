using CsvHelper.Configuration.Attributes;

namespace BillingEngine.Parsers.Models
{
    public class ParsedEc2InstanceType
    {
        [Name("InstanceType")]
        public string Ec2InstanceType { get; set; }
        [Name("ChargePerHour")]
        public string CostPerHour { get; set; }
    }
}
using System;

namespace BillingEngine.Parsers.Models
{
    public class ParsedEc2ResourceUsageEventRecord
    {
        public string CustomerId { get; set; }
        public string Ec2InstanceId { get; set; }
        public string Ec2InstanceType { get; set; }
        public DateTime UsedFrom { get; set; }
        public DateTime UsedUntil { get; set; }
    }
}
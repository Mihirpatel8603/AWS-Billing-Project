using CsvHelper.Configuration.Attributes;
using System;

namespace BillingEngine.Parsers.Models
{
    public class ParsedEc2ResourceUsageEventRecord
    {
        [Name("CustomerId")]
        public string CustomerId { get; set; }
        [Name("Ec2InstanceId")]
        public string Ec2InstanceId { get; set; }
        [Name("Ec2InstanceType")]
        public string Ec2InstanceType { get; set; }
        [Name("UsedFrom")]
        public DateTime UsedFrom { get; set; }
        [Name("UsedUntil")]
        public DateTime UsedUntil { get; set; }
    }
}
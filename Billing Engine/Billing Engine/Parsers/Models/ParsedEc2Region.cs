using CsvHelper.Configuration.Attributes;

namespace BillingEngine.Parsers.Models
{
    public class ParsedEc2Region
    {
        [Name("Region")]
        public string RegionName { get; set; }
        [Name("Freee Tier Eligible")]
        public string FreeTierEligibleInstanceType { get; set; }
    }
}
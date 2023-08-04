using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using CsvHelper;
using BillingEngine.Parsers.Models;

namespace BillingEngine.Parsers
{
    public class Ec2ResourceUsageTypeEventParser
    {

        public List<ParsedEc2ResourceUsageEventRecord> Parse(string filePath)
        {
            using StreamReader streamReader = File.OpenText(filePath);
            using var csvReader = new CsvReader(streamReader, CultureInfo.CurrentCulture);

            
            return new List<ParsedEc2ResourceUsageEventRecord>();
        }
    }
}
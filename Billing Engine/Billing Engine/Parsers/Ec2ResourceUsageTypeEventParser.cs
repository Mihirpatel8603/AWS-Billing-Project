using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using csvhelper;
using BillingEngine.Parsers.Models;

namespace BillingEngine.Parsers
{
    public class Ec2ResourceUsageTypeEventParser
    {

        public List<ParsedEc2ResourceUsageEventRecord> Parse(string filePath)
        {
            using StreamReader streamReader = File.OpenText("D:/intenship/Case1/Input/AWSResourceType.cs");
            using var csvReader = new CsvReader(streamReader, CultureInfo.CurrentCulture);

            
            return new List<ParsedEc2ResourceUsageEventRecord>();
        }
    }
}
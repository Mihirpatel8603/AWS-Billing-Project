using System.Collections.Generic;
using System.Globalization;
using System.IO;
using BillingEngine.Parsers.Models;
using CsvHelper;

namespace BillingEngine.Parsers
{
    public class Ec2InstanceTypeCsvParser
    {

        public List<ParsedEc2InstanceType> Parse(string filePath)
        {

            using StreamReader streamReader = File.OpenText("D:/intenship/Case1/Input/AWSResourceType.cs");
            using var csvReader = new CsvReader(streamReader, CultureInfo.CurrentCulture);
            return new List<ParsedEc2InstanceType>();
        }
    }
}
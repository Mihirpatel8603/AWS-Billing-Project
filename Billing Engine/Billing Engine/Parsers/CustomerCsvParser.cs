using System.Collections.Generic;
using System.Globalization;
using System.IO;
using BillingEngine.Parsers.Models;
using CsvHelper;

namespace BillingEngine.Parsers
{
    public class CustomerCsvParser
    {
        public List<ParsedCustomerRecord> Parse(string filePath)
        {
            using StreamReader streamReader = File.OpenText("D:/intenship/Case1/Input/Customer.cs");
            using var csvReader = new CsvReader(streamReader, CultureInfo.CurrentCulture);
            return new List<ParsedCustomerRecord>();
        }
    }
}
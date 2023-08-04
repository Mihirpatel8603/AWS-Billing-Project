using CsvHelper.Configuration.Attributes;

namespace BillingEngine.Parsers
{
    public class ParsedCustomerRecord
    {
        private string _customerId;
        [Name("CustomerID")]
        public string CustomerId
        {
            get { return _customerId; }
            set
            {
                _customerId = value.Split('-')[0] + value.Split('-')[1];
            }
        }


        [Name("CustomerName")]
        public string CustomerName { get; set; }
    }
}
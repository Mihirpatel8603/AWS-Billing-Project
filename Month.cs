using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Billing_Project
{
    internal class Month
    {
        string custId = "";
        string name = "";
        List<Usages> usages = new List<Usages>();
        List<Type> types = new List<Type>();

        public Month() { }


        public Month(string name, string custId)
        {

            this.name = name;
            this.custId = custId;

        }

        public void addUsages(Usages usages)
        {
            this.usages.Add(usages);

        }

        public string getName()
        {
            return this.name;
        }
    }
}

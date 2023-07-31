using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Billing_Project
{
    internal class Users
    {
        string userId = "";
        string userName = "";
        List<Month> months = new List<Month>();

        public Users() { }
        public Users(string userId)
        {

            this.userId = userId;
        }
        public string GetUserId()
        {
            return this.userId;
        }

        public List<Month> getmonths()
        {
            return this.months;
        }
    }

}

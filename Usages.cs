using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Billing_Project
{
    internal class Usages
    {
        string custId = "";
        string Ec2Instance = "";
        string From = "";
        string Until = "";
        string Ec2Type = "";


        public string getcustId()
        {
            return this.custId;
        }

        public string getEc2Instance()
        {
            return this.Ec2Instance;
        }

        public string getFrom()
        {
            return this.From;
        }

        public string getUntil()
        {
            return this.Until;
        }

        public string getEc2Type()
        {
            return (string)this.Ec2Type;
        }

        public int Secounds()
        {
            string[] delimetrs = { ":", "-", "T" };
            String[] start = this.From.Split(delimetrs, StringSplitOptions.None);
            String[] end = this.Until.Split(delimetrs, StringSplitOptions.None);

            int[] Day1 = new int[6];
            int[] Day2 = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Day1[i] = int.Parse(start[i]);
                Day2[i] = int.Parse(end[i]);
            }
            DateTime date1 = new DateTime(Day1[0], Day1[1], Day1[2], Day1[3], Day1[4], Day1[5]);
            DateTime date2 = new DateTime(Day2[0], Day2[1], Day2[2], Day2[3], Day2[4], Day2[5]);

            TimeSpan ts = date2 - date1;

            int secounds = (int)(ts.TotalSeconds);

            return secounds;
        }
        public void printUsages()
        {
            Console.WriteLine(this.custId + " " + this.Ec2Instance + " " + this.Ec2Type + " " + this.From + " " + this.Until);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.IO;
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;
using System.Security.AccessControl;
using System.Runtime.InteropServices;
using System.Text;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;
using AWS_Billing_Project;

class program
{
    static void Main(String[] args)
    {
        string path = "D:/intenship/Case1/Input/AWSCustomerUsage.csv";



        string[] usage = File.ReadAllLines(path);

        for (int i = 0; i < usage.Length; i++)
        {
            Console.WriteLine(usage[i]);
        }

        List<Users> allusers = new List<Users>();

        for (int i = 1; i < usage.Length; i++)
        {
            string record = usage[i];

            string[] delimetrs = { "\"", ",", " " };
            String[] values = record.Split(delimetrs, StringSplitOptions.None);

            Session session = new Session(values[4], values[7], values[10], values[13], values[16]);

           

            
            bool flag = false;
            for (int j = 0; j < allusers.Count; j++)
            {
                Users cust = allusers[j];

                if (cust.getuserId().Equals(values[4]))
                {
                    cust.addsessions(session);
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                Users cust = new Users(values[4]);
                cust.addsessions(session);

                allusers.Add(cust);
            }
        
            
        }


        for (int i = 0; i < allusers.Count; i++)
        {
            Users cust = allusers[i];

            List<Month> months = cust.getmonths();

            for (int j = 0; j < months.Count; j++)
            {
                Month mon = months[j];

                mon.gereratebill();

            }
        }
           
        /*  for (int i = 0; i < usage1.Length; i++)
          {
              Console.WriteLine(usage1[i]);
          }
          /* type t1 = new type() 
               t1.customers();
               t1.showdata();
           }*/
    }


}










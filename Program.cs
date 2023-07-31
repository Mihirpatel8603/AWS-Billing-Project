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





class Program
{
    static void Main(String[] args)
    {
        string path = "D:/intenship/Case1/Input/AWSCustomerUsage.csv";



        string[] usage = File.ReadAllLines(path);

        for (int i = 0; i < usage.Length; i++)
        {
            Console.WriteLine(usage[i]);
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














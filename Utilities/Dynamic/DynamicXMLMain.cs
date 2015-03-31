using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utilities.Dynamic
{
    public class DynamicXMLMain
    {
        static void Main(string[] args)
        {
            dynamic doc = new DynamicXml("Exmployees.xml");
            foreach (var employee in doc.Employees)
            {
                Console.WriteLine(employee.FirstName);
            }

            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Dynamic;

namespace Utilities.Expando
{
    public class XML
    {
        static void Main(string[] args)
        {
            var doc = XDocument.Load("Blank.xml").AsExpando();
        }
    }
}
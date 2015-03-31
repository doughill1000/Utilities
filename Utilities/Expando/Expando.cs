using System;
using System.Dynamic;

namespace Utilities.Expando
{
    public class Expando
    {
        //ExpandoObject is dynamic object. Can add properties and methods on the fly
        static void Main(string[] args)
        {
            dynamic expando = new ExpandoObject();
            expando.Name = "Doug";
            expando.Speak = new Action(() => System.Console.WriteLine(expando.Name));

           foreach (var mem in expando)
           {
               Console.WriteLine(mem.Key);
           }
        }
    }
}
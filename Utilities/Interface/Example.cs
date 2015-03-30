using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utilities.Interface
{
    public class Example : IExample
    {
        //Implicit Cast
        public void Method()
        {
            throw new NotImplementedException();
        }

        //Explicit Cast
        void IExample.Method()
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace M1.Scrap
{
    public static class ClassExtension
    {

        public static string GetFullName(this TestClass testObject)
        {
            return testObject.firstname + " " + testObject.lastname;

        }
    }
}

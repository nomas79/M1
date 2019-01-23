using System;
using System.Collections.Generic;
using System.Text;

namespace M1.Scrap
{
   static class ClassExtension2
    {


        public static string GetIntroduction(this TestClass testObject)
        {
            var fullname = testObject.GetFullName();
            return "Hi " + fullname;

        }
    }
}

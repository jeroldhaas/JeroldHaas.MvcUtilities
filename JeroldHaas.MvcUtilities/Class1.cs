using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeroldHaas.MvcUtilities
{
    public static class Controller
    {
        public static string nameofcontroller(Type t)
        {
            var name = nameof(t);
            if (name.Contains("Controller"))
            {
                return name.Substring(
                    0,
                    name.IndexOf(@"Controller") - 1
                );
            }
            else return "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia
{
   
    static class Global
    {
        private static string _globalVar = "";
        private static string _globalPass = "";

        public static string GlobalSessionNombre
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }

        public static string GlobalSessionPass
        {
            get { return _globalPass; }
            set { _globalPass = value; }
        }
    }
}

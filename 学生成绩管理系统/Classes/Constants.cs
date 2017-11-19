using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 第二题.Classes
{
    public class Constants
    {
        private static string username;

        public static string Username
        {
            get { return username; }
            set { username = value; }
        }

        private static string userlevel;

        public static string Userlevel
        {
            get { return userlevel; }
            set { userlevel = value; }
        }
    }
}

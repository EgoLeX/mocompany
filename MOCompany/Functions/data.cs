using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOCompany.Functions
{
    class data
    {
        //
        //  general save settings
        //


        public static String version = "V1.0.0";
        public static String pathtoomsidir = "";
        public static String pthdriverdir = "\\Drivers\\mocusr.odr";

        //  company values
        public static Boolean usrhascompany = false;
        public static int companytype = 0;  // 0=noCompany - 1=c01 - 2=c02 .....
        public static String companyname = "";


        //
        //  user save settings
        //


        public static String usrname = "mocusr";
        public static String password = "0123";
        public static double usr_bankaccvalue = 30000;  //default 3000 MCD
        public static double comp_bankaccvalue = 0;

        //  driverdata
        public static String crashes = "0";
        public static String driven_km = "0";
        public static String hitandruns = "0";
        public static String injured_pedestrians = "0";
        public static String busstops = "0";
        public static String soldtickets = "0";
        public static double income = 0;

    }
}

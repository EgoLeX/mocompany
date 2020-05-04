using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOCompany.Functions
{
    class propfiles
    {
        public static void save()
        {
            Properties.Settings.Default.gs_omsidir = data.pathtoomsidir;
            Properties.Settings.Default.usr_comp_has = data.usrhascompany;
            Properties.Settings.Default.usr_comp_type = data.companytype;
            Properties.Settings.Default.usr_username = data.usrname;
            Properties.Settings.Default.usr_password = data.password;
            Properties.Settings.Default.usr_bankaccvalue = data.usr_bankaccvalue;
            Properties.Settings.Default.comp_bankaccvalue = data.comp_bankaccvalue;

            //saving
            Properties.Settings.Default.Save();
        }
        
        public static void load()
        {
            data.pathtoomsidir = Properties.Settings.Default.gs_omsidir;
            data.usrhascompany = Properties.Settings.Default.usr_comp_has;
            data.companytype = Properties.Settings.Default.usr_comp_type;
            data.usrname = Properties.Settings.Default.usr_username;
            data.password = Properties.Settings.Default.usr_password;
            data.usr_bankaccvalue = Properties.Settings.Default.usr_bankaccvalue;
            data.comp_bankaccvalue = Properties.Settings.Default.comp_bankaccvalue;
        }
    }
}

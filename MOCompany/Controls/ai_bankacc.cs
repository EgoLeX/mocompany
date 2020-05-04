using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOCompany.Controls
{
    public partial class ai_bankacc : UserControl
    {

        public ai_bankacc()
        {
            InitializeComponent();
            onLoadAccBalance();
            timerBankTime.Start();
            lb_footer_time.Text = "Time: "+DateTime.Now.ToString("HH:mm:ss tt");
            this.lb_bankpg_bacc1_accnameofperson.Text = Functions.data.usrname;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_footer_time.Text = "Time: " + DateTime.Now.ToString("HH:mm:ss tt");
            timerBankTime.Start();
        }

        //for ai and own Mode
        public void addBankAccValue(double valuetoadd)
        {
            Functions.data.usr_bankaccvalue = Functions.data.usr_bankaccvalue + valuetoadd;
        }
        public void removeBankAccValue(double valuetoremove)
        {
            Functions.data.usr_bankaccvalue = Functions.data.usr_bankaccvalue - valuetoremove;
        }

        private void onLoadAccBalance()
        {
            this.lb_bankpg_bacc1_balance.Text = String.Format("{0:0.00 MCD}", Functions.data.usr_bankaccvalue);
        }
    }
}

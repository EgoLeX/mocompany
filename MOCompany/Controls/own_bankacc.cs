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
    public partial class own_bankacc : UserControl
    {
        public own_bankacc()
        {
            InitializeComponent();
            onLoadAccBalance();
            this.lb_bankpg_bacc1_accnameofcompany.Text = Functions.data.companyname;
            this.lb_bankpg_bacc2_nameofperson.Text = Functions.data.usrname;
        }

        private void tb_value_totransfer_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!Char.IsDigit(c) && !Char.IsControl(c))
            {
                e.Handled = true;
            }
        }

        private void transfer_priv_comp(double valuetotransfer)
        {
            // private -> company
            if (Functions.data.usr_bankaccvalue - valuetotransfer >= 0)
            {
                Functions.data.usr_bankaccvalue = Functions.data.usr_bankaccvalue - valuetotransfer;
                Functions.data.comp_bankaccvalue = Functions.data.comp_bankaccvalue + valuetotransfer;
                onLoadAccBalance();
            } else
            {
                MessageBox.Show("You don't have so much money to transfer!");
            }
            
        }
        private void transfer_comp_priv(double valuetotransfer)
        {
            // company -> private
            if (Functions.data.comp_bankaccvalue - valuetotransfer >= 0)
            {
                Functions.data.comp_bankaccvalue = Functions.data.comp_bankaccvalue - valuetotransfer;
                Functions.data.usr_bankaccvalue = Functions.data.usr_bankaccvalue + valuetotransfer;
                onLoadAccBalance();
            }
            else
            {
                MessageBox.Show("You don't have "+valuetotransfer+" MCDs to transfer!");
            }

        }

        public void addBankAccValueOwn(double valuetoadd)
        {
            Functions.data.comp_bankaccvalue = Functions.data.comp_bankaccvalue + valuetoadd;
        }
        public void removeBankAccValueOwn(double valuetoremove)
        {
            Functions.data.comp_bankaccvalue = Functions.data.comp_bankaccvalue - valuetoremove;
        }

        private void onLoadAccBalance()
        {
            this.lb_bankpg_bacc2_balance.Text = String.Format("{0:0.00 MCD}", Functions.data.usr_bankaccvalue);
            this.lb_bankpg_bacc1_balance.Text = String.Format("{0:0.00 MCD}", Functions.data.comp_bankaccvalue);
        }

        private void btn_transfer_priv_comp_Click(object sender, EventArgs e)
        {
            if (!tb_value_totransfer.Text.Equals(""))
            {
                transfer_priv_comp(Double.Parse(tb_value_totransfer.Text));
            }  
        }

        private void btn_transfer_comp_priv_Click(object sender, EventArgs e)
        {
            if (!tb_value_totransfer.Text.Equals(""))
            {
                transfer_comp_priv(Double.Parse(tb_value_totransfer.Text));
            }
        }
    }
}

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
    public partial class gl_companymarket : UserControl
    {
        public gl_companymarket()
        {
            InitializeComponent();
        }

        private Boolean checkIfCompExists()
        {
            Boolean hascomp;
            if (Functions.data.usrhascompany)
            {
                hascomp = true;
            } else
            {
                hascomp = false;
            }
            return hascomp;
        }

        private void showMsgBox(String msg, Boolean type, int companytype, double ValueToRemovefromBankAcc)
        {
            DialogResult result;

            if (type == false)
            {
                // false = "OK" MSG-Box
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //else == buy
                result = MessageBox.Show(msg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(result == DialogResult.Yes)
                {
                    onBuyAcceptAction(ValueToRemovefromBankAcc, companytype);
                }
            }
        }

        private void onBuyAcceptAction(double ValueToRemovefromBankAcc , int companytype)
        {
            if (ValueToRemovefromBankAcc > Functions.data.usr_bankaccvalue)
            {
                String msg_notenoughmoney = "You do not have enough money to buy this!";
                showMsgBox(msg_notenoughmoney, false, 0, 0);
            }
            else
            {
                //remove money from bank account
                ai_bankacc aib = new ai_bankacc();
                aib.removeBankAccValue(ValueToRemovefromBankAcc);

                //set userhascompany to true
                Functions.data.usrhascompany = true;
                Functions.data.companytype = companytype;

                showMsgBox("You have bought this company for " + ValueToRemovefromBankAcc + " MCD.\nYou can logout now and login into your own company if you prefere to do it.", false, 0, 0);
            }
        }

        private void btn_comp_c01_buy_Click(object sender, EventArgs e)
        {
            //buy button pressed on company c01
            String msgbuycomp = "Would you like to buy this Company (c01) for 10.000 MCD?";
            showMsgBox(msgbuycomp, true, 1, 10000);
        }

        private void btn_comp_c02_buy_Click(object sender, EventArgs e)
        {
            //buy button pressed on company c02
            String msgbuycomp = "Would you like to buy this Company (c02) for 15.000 MCD?";
            showMsgBox(msgbuycomp, true, 2, 15000);
        }

        private void btn_comp_c03_buy_Click(object sender, EventArgs e)
        {
            //buy button pressed on company c03
            String msgbuycomp = "Would you like to buy this Company (c03) for 21.000 MCD?";
            showMsgBox(msgbuycomp, true, 3, 21000);
        }

        private void btn_comp_c04_buy_Click(object sender, EventArgs e)
        {
            //buy button pressed on company c04
            String msgbuycomp = "Would you like to buy this Company (c04) for 30.000 MCD?";
            showMsgBox(msgbuycomp, true, 4, 30000);
        }
    }
}

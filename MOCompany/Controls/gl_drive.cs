using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOCompany.Controls
{
    public partial class gl_drive : UserControl
    {

        //ags = at game start ; age = at game end
        private int ags_injuredpedestrians;
        private int ags_crashes;
        private int ags_hitandruns;
        private int ags_soldtickets;
        private int ags_holdbusstops;
        private double ags_earnedmoney;

        private int age_injuredpedestrians;
        private int age_crashes;
        private int age_hitandruns;
        private int age_soldtickets;
        private int age_holdbusstops;
        private double age_earnedmoney;

        private double earnedmoney = 0, boni = 0;

        public gl_drive()
        {
            InitializeComponent();
        }

        private void btn_drive_startdriving_Click(object sender, EventArgs e)
        {
            if (Functions.data.pathtoomsidir.Contains("OMSI"))
            {
                //if selected dir contains OMSI than start the omsi.exe
                System.Diagnostics.Process.Start(@Functions.data.pathtoomsidir + "\\Omsi.exe");

                ags_injuredpedestrians = int.Parse(System.IO.File.ReadLines(Functions.data.pathtoomsidir + Functions.data.pthdriverdir).Skip(25).Take(1).First());
                ags_crashes = int.Parse(System.IO.File.ReadLines(Functions.data.pathtoomsidir + Functions.data.pthdriverdir).Skip(22).Take(1).First());
                ags_hitandruns = int.Parse(System.IO.File.ReadLines(Functions.data.pathtoomsidir + Functions.data.pthdriverdir).Skip(23).Take(1).First());
                ags_soldtickets = int.Parse(System.IO.File.ReadLines(Functions.data.pathtoomsidir + Functions.data.pthdriverdir).Skip(28).Take(1).First());
                ags_holdbusstops = int.Parse(System.IO.File.ReadLines(Functions.data.pathtoomsidir + Functions.data.pthdriverdir).Skip(14).Take(1).First());
                ags_earnedmoney = double.Parse(getMoneyAsString(), CultureInfo.InvariantCulture.NumberFormat);

                if (MessageBox.Show("OMSI is starting, please wait a moment ... \n\nOnce you've finished your tour, click OK to load Data \n(Please close OMSI2 before pressing OK!)", "Driving", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    //load data from driver file
                    age_injuredpedestrians = int.Parse(System.IO.File.ReadLines(Functions.data.pathtoomsidir + Functions.data.pthdriverdir).Skip(25).Take(1).First());
                    age_crashes = int.Parse(System.IO.File.ReadLines(Functions.data.pathtoomsidir + Functions.data.pthdriverdir).Skip(22).Take(1).First());
                    age_hitandruns = int.Parse(System.IO.File.ReadLines(Functions.data.pathtoomsidir + Functions.data.pthdriverdir).Skip(23).Take(1).First());
                    age_soldtickets = int.Parse(System.IO.File.ReadLines(Functions.data.pathtoomsidir + Functions.data.pthdriverdir).Skip(28).Take(1).First());
                    age_holdbusstops = int.Parse(System.IO.File.ReadLines(Functions.data.pathtoomsidir + Functions.data.pthdriverdir).Skip(14).Take(1).First());
                    age_earnedmoney = double.Parse(getMoneyAsString(), CultureInfo.InvariantCulture.NumberFormat);

                    //calculations
                    double moneyfsoldtickets = age_earnedmoney - ags_earnedmoney;
                    double holdbusstops = age_holdbusstops - ags_holdbusstops;
                    earnedmoney = (moneyfsoldtickets * 2.5) + (holdbusstops * 10); //earnedmoney = (sold tickets *2.5) + (10 MCDs for every holded Busstop)

                    if(age_crashes - ags_crashes > 0)
                    {
                        earnedmoney = earnedmoney - ((age_crashes - ags_crashes)*10);
                    } else
                    {
                        boni = earnedmoney * 0.3;
                    } 
                    
                    if (age_injuredpedestrians - ags_injuredpedestrians > 0)
                    {
                        earnedmoney = earnedmoney - ((age_injuredpedestrians - ags_injuredpedestrians) * 7);
                    } else
                    {
                        boni = earnedmoney * 0.2;
                    }
                    
                    if (age_hitandruns - ags_hitandruns > 0)
                    {
                        earnedmoney = earnedmoney - ((age_hitandruns - ags_hitandruns) * 4);
                    }

                    earnedmoney = earnedmoney + boni;

                    //
                    this.rtb_drive_evaluation.Text = "Evaluation of the last trip:\n\n\n" +
                        "Crashes: "+(age_crashes-ags_crashes)+"\n" +
                        "Injured Pedestrians: "+(age_injuredpedestrians-ags_injuredpedestrians)+"\n" +
                        "Hit and Runs: "+(age_hitandruns-ags_hitandruns)+"\n" +
                        "\n" +
                        "Sold tickets: "+(age_soldtickets-ags_soldtickets)+"\n"+
                        "Money f. sold tickets: "+ String.Format("{0:0.00 €}", moneyfsoldtickets) +"\n"+
                        "\n\n" +
                        "Earned money f. this session: "+ String.Format("{0:0.00 MCD}", earnedmoney) +"\n" +
                        "\n\n" +
                        "To get payed for this session you need to accept this Evaluation.\n" +
                        "You can do it by clicking on the Accept Button!";
                } 
            }
            else
            {
                MessageBox.Show("You need to choose your Omsi main directory first! ( Settings! )");
            }
        }

        private void btn_drive_acceptdrive_Click(object sender, EventArgs e)
        {
            Controls.ai_bankacc cbankacc = new ai_bankacc();
            if (earnedmoney != 0)
            {
                cbankacc.addBankAccValue(earnedmoney);

                //clear variables to secure for bugusing
                this.rtb_drive_evaluation.Text = "";
                earnedmoney = 0;
                boni = 0;
            }

        }

        private String getMoneyAsString()
        {
            String strret = System.IO.File.ReadLines(Functions.data.pathtoomsidir + Functions.data.pthdriverdir).Skip(29).Take(1).First();
            return strret;
        }
    }
}

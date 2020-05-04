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
    public partial class gl_driverdata : UserControl
    {

        public gl_driverdata()
        {
            InitializeComponent();
            loadValues();
        }

        public void loadValues()
        {
            //get values and write it to global
            Functions.data.driven_km = calcKM();
            Functions.data.busstops = System.IO.File.ReadLines(Functions.data.pathtoomsidir + Functions.data.pthdriverdir).Skip(14).Take(1).First();
            Functions.data.soldtickets = System.IO.File.ReadLines(Functions.data.pathtoomsidir + Functions.data.pthdriverdir).Skip(28).Take(1).First();
            Functions.data.income = double.Parse(System.IO.File.ReadLines(Functions.data.pathtoomsidir + Functions.data.pthdriverdir).Skip(29).Take(1).First().ToString(), System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            Functions.data.crashes = System.IO.File.ReadLines(Functions.data.pathtoomsidir + Functions.data.pthdriverdir).Skip(22).Take(1).First();
            Functions.data.hitandruns = System.IO.File.ReadLines(Functions.data.pathtoomsidir + Functions.data.pthdriverdir).Skip(23).Take(1).First();
            Functions.data.injured_pedestrians = System.IO.File.ReadLines(Functions.data.pathtoomsidir + Functions.data.pthdriverdir).Skip(25).Take(1).First();

            //write global values to driverdata boxes
            this.lb_driverdata_drivenkms_value.Text = Functions.data.driven_km;
            this.lb_driverdata_busstops_value.Text = Functions.data.busstops;
            this.lb_driverdata_boughttickets_value.Text = Functions.data.soldtickets;
            this.lb_driverdata_money_value.Text = String.Format("{0:0.00 €}", Functions.data.income);
            this.lb_driverdata_crashes_value.Text = Functions.data.crashes;
            this.lb_driverdata_hitandruns_value.Text = Functions.data.hitandruns;
            this.lb_driverdata_injuredpedestrians_value.Text = Functions.data.injured_pedestrians;
        }

        private String calcKM()
        {
            String km_normal = System.IO.File.ReadLines(Functions.data.pathtoomsidir + Functions.data.pthdriverdir).Skip(19).Take(1).First();
            String km_end;
            if (km_normal.Equals("0"))
            {
                return km_normal;
            } else {     
                String km_last = km_normal[km_normal.Length - 1].ToString();
                km_end = km_normal.Substring(0, km_normal.Length - 1) + "," + km_last;
                return km_end;
            }
        }
    }
}

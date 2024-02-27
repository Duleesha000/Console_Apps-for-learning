using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        business_logic obj=new business_logic();

        private void btn_cal_Click(object sender, EventArgs e)
        {
            double day, night,tot=0;
            day = Convert.ToDouble(txt_day.Text);
            night = Convert.ToDouble(txt_night.Text);

            if (cmb_ptype.SelectedIndex == 0)
            {

                tot = obj.day_blast_cal(day, night);
                txt_tot.Text = tot.ToString();
                
            }
            else if(cmb_ptype.SelectedIndex == 1)
            {

                tot = obj.night_blast_cal(day, night);
                txt_tot.Text = tot.ToString();
            }

            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_day.Clear();
            txt_night.Clear();
            txt_tot.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

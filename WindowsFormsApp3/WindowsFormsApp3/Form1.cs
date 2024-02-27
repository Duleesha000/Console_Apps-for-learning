using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            double tot, unit;
            unit = Convert.ToDouble(txt_uni.Text);

            if (cmb_cus.SelectedIndex==0)
            {
                
                
                tot = 500 + (unit - 100) * 20 + 200;
                txt_tot.Text = tot.ToString();
            }
            else 
            {
                
                tot = 800 + (unit - 100) * 50 + 600;
                txt_tot.Text = tot.ToString();
            }
        }

        private void lbl_uni_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

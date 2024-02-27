using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            double salary, allow,n_sal, epf;

            salary = Convert.ToDouble(txt_bs.Text);
            allow=Convert.ToDouble(txt_allow.Text);
            epf = salary * 10 / 100;
            n_sal = salary + allow - epf;
            txt_ns.Text = n_sal.ToString();

        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            txt_bs.Clear();
            txt_allow.Clear();
            txt_ns.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

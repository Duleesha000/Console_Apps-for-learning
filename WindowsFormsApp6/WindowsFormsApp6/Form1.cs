using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            double bs=0,wr=0, wh=0, tsal=0, nsal=0,tax=0;
            bs = Convert.ToDouble(txt_bs.Text);
            wh = Convert.ToDouble(txt_wh.Text);

            if (cmb_emp_type.SelectedIndex == 0)
            {
                wr = 1500;
                lbl_wr.Text = wr.ToString();
                tsal = bs + (wh *wr);
                if (tsal<50000)
                {
                    tax = tsal * 6/100;
                }
                else if (tsal>50000)
                {
                    tax = tsal * 8/100;
                }
                else if (tsal>10000)
                {
                    tax = tsal * 10/100;
                }
                else if (tsal>150000)
                {
                    tax = tsal * 12/100;
                }

                nsal = tsal - tax;
                txt_tsal.Text = tsal.ToString();
                txt_nsal.Text = nsal.ToString();

                MessageBox.Show("Net Salary =" + nsal, "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                

            }
            else if (cmb_emp_type.SelectedIndex == 1)
            {
                wr = 2000;
                lbl_wr.Text = wr.ToString();
                tsal = bs + (wh * wr);
                if (tsal < 50000)
                {
                    tax = tsal * 6 / 100;
                }
                else if (tsal > 50000)
                {
                    tax = tsal * 8 / 100;
                }
                else if (tsal > 10000)
                {
                    tax = tsal * 10 / 100;
                }
                else if (tsal > 150000)
                {
                    tax = tsal * 12 / 100;
                }

                nsal = tsal - tax;
                txt_tsal.Text = tsal.ToString();
                txt_nsal.Text = nsal.ToString();

                MessageBox.Show("Net Salary =" + nsal, "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


            }

            else if (cmb_emp_type.SelectedIndex == 2)
            {
                wr = 3000;
                lbl_wr.Text = wr.ToString();
                tsal = bs + (wh * wr);
                if (tsal < 50000)
                {
                    tax = tsal * 6 / 100;
                }
                else if (tsal > 50000)
                {
                    tax = tsal * 8 / 100;
                }
                else if (tsal > 10000)
                {
                    tax = tsal * 10 / 100;
                }
                else if (tsal > 150000)
                {
                    tax = tsal * 12 / 100;
                }

                nsal = tsal - tax;
                txt_tsal.Text = tsal.ToString();
                txt_nsal.Text = nsal.ToString();

                MessageBox.Show("Net Salary =" + nsal, "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_bs.Clear();
            lbl_wr.Text="";
            txt_wh.Clear();
            txt_tsal.Clear();
            txt_nsal.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

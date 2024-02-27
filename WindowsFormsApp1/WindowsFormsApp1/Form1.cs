using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            label1.Visible=true;
            String name;
            name=txt_name.Text;
            label1.Text = "Hi Welcome " + name;
        }
    }
}

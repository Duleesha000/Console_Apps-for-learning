namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_emp_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_bs = new System.Windows.Forms.TextBox();
            this.txt_wh = new System.Windows.Forms.TextBox();
            this.txt_tsal = new System.Windows.Forms.TextBox();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nsal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_wr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_emp_type
            // 
            this.cmb_emp_type.FormattingEnabled = true;
            this.cmb_emp_type.Items.AddRange(new object[] {
            "Jse",
            "Sse",
            "Tled"});
            this.cmb_emp_type.Location = new System.Drawing.Point(317, 43);
            this.cmb_emp_type.Name = "cmb_emp_type";
            this.cmb_emp_type.Size = new System.Drawing.Size(121, 24);
            this.cmb_emp_type.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Basic Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Weekend Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Salary";
            // 
            // txt_bs
            // 
            this.txt_bs.Location = new System.Drawing.Point(317, 95);
            this.txt_bs.Name = "txt_bs";
            this.txt_bs.Size = new System.Drawing.Size(100, 22);
            this.txt_bs.TabIndex = 6;
            // 
            // txt_wh
            // 
            this.txt_wh.Location = new System.Drawing.Point(317, 208);
            this.txt_wh.Name = "txt_wh";
            this.txt_wh.Size = new System.Drawing.Size(100, 22);
            this.txt_wh.TabIndex = 8;
            // 
            // txt_tsal
            // 
            this.txt_tsal.Location = new System.Drawing.Point(317, 264);
            this.txt_tsal.Name = "txt_tsal";
            this.txt_tsal.Size = new System.Drawing.Size(100, 22);
            this.txt_tsal.TabIndex = 9;
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(56, 385);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(75, 23);
            this.btn_cal.TabIndex = 10;
            this.btn_cal.Text = "Calculate";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(317, 385);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(572, 385);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Net Salary";
            // 
            // txt_nsal
            // 
            this.txt_nsal.Location = new System.Drawing.Point(317, 314);
            this.txt_nsal.Name = "txt_nsal";
            this.txt_nsal.Size = new System.Drawing.Size(100, 22);
            this.txt_nsal.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Weekend rate";
            // 
            // lbl_wr
            // 
            this.lbl_wr.AutoSize = true;
            this.lbl_wr.Location = new System.Drawing.Point(314, 152);
            this.lbl_wr.Name = "lbl_wr";
            this.lbl_wr.Size = new System.Drawing.Size(92, 16);
            this.lbl_wr.TabIndex = 15;
            this.lbl_wr.Text = "*****************";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_wr);
            this.Controls.Add(this.txt_nsal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.txt_tsal);
            this.Controls.Add(this.txt_wh);
            this.Controls.Add(this.txt_bs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_emp_type);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_emp_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_bs;
        private System.Windows.Forms.TextBox txt_wh;
        private System.Windows.Forms.TextBox txt_tsal;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nsal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_wr;
    }
}


namespace WindowsFormsApp2
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
            this.lbl_bs = new System.Windows.Forms.Label();
            this.lbl_allow = new System.Windows.Forms.Label();
            this.lbl_ns = new System.Windows.Forms.Label();
            this.txt_bs = new System.Windows.Forms.TextBox();
            this.txt_allow = new System.Windows.Forms.TextBox();
            this.txt_ns = new System.Windows.Forms.TextBox();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_cls = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_bs
            // 
            this.lbl_bs.AutoSize = true;
            this.lbl_bs.Location = new System.Drawing.Point(81, 62);
            this.lbl_bs.Name = "lbl_bs";
            this.lbl_bs.Size = new System.Drawing.Size(83, 16);
            this.lbl_bs.TabIndex = 0;
            this.lbl_bs.Text = "Basic Salary";
            // 
            // lbl_allow
            // 
            this.lbl_allow.AutoSize = true;
            this.lbl_allow.Location = new System.Drawing.Point(84, 155);
            this.lbl_allow.Name = "lbl_allow";
            this.lbl_allow.Size = new System.Drawing.Size(69, 16);
            this.lbl_allow.TabIndex = 1;
            this.lbl_allow.Text = "Allowance";
            // 
            // lbl_ns
            // 
            this.lbl_ns.AutoSize = true;
            this.lbl_ns.Location = new System.Drawing.Point(80, 235);
            this.lbl_ns.Name = "lbl_ns";
            this.lbl_ns.Size = new System.Drawing.Size(70, 16);
            this.lbl_ns.TabIndex = 2;
            this.lbl_ns.Text = "Net Salary";
            // 
            // txt_bs
            // 
            this.txt_bs.Location = new System.Drawing.Point(261, 62);
            this.txt_bs.Name = "txt_bs";
            this.txt_bs.Size = new System.Drawing.Size(100, 22);
            this.txt_bs.TabIndex = 3;
            // 
            // txt_allow
            // 
            this.txt_allow.Location = new System.Drawing.Point(261, 148);
            this.txt_allow.Name = "txt_allow";
            this.txt_allow.Size = new System.Drawing.Size(100, 22);
            this.txt_allow.TabIndex = 4;
            // 
            // txt_ns
            // 
            this.txt_ns.Location = new System.Drawing.Point(261, 221);
            this.txt_ns.Name = "txt_ns";
            this.txt_ns.Size = new System.Drawing.Size(100, 22);
            this.txt_ns.TabIndex = 5;
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(84, 355);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(99, 23);
            this.btn_cal.TabIndex = 6;
            this.btn_cal.Text = "Calculate";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // btn_cls
            // 
            this.btn_cls.Location = new System.Drawing.Point(286, 355);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(89, 23);
            this.btn_cls.TabIndex = 7;
            this.btn_cls.Text = "Cear";
            this.btn_cls.UseVisualStyleBackColor = true;
            this.btn_cls.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(457, 354);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_cls);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.txt_ns);
            this.Controls.Add(this.txt_allow);
            this.Controls.Add(this.txt_bs);
            this.Controls.Add(this.lbl_ns);
            this.Controls.Add(this.lbl_allow);
            this.Controls.Add(this.lbl_bs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_bs;
        private System.Windows.Forms.Label lbl_allow;
        private System.Windows.Forms.Label lbl_ns;
        private System.Windows.Forms.TextBox txt_bs;
        private System.Windows.Forms.TextBox txt_allow;
        private System.Windows.Forms.TextBox txt_ns;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_cls;
        private System.Windows.Forms.Button btn_exit;
    }
}


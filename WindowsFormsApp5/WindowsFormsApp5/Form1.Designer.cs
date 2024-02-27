namespace WindowsFormsApp5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_day = new System.Windows.Forms.TextBox();
            this.txt_night = new System.Windows.Forms.TextBox();
            this.txt_tot = new System.Windows.Forms.TextBox();
            this.cmb_ptype = new System.Windows.Forms.ComboBox();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Package  Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Units at Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Units at night";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total";
            // 
            // txt_day
            // 
            this.txt_day.Location = new System.Drawing.Point(264, 124);
            this.txt_day.Name = "txt_day";
            this.txt_day.Size = new System.Drawing.Size(100, 22);
            this.txt_day.TabIndex = 4;
            // 
            // txt_night
            // 
            this.txt_night.Location = new System.Drawing.Point(264, 174);
            this.txt_night.Name = "txt_night";
            this.txt_night.Size = new System.Drawing.Size(100, 22);
            this.txt_night.TabIndex = 5;
            // 
            // txt_tot
            // 
            this.txt_tot.Location = new System.Drawing.Point(264, 221);
            this.txt_tot.Name = "txt_tot";
            this.txt_tot.Size = new System.Drawing.Size(100, 22);
            this.txt_tot.TabIndex = 6;
            // 
            // cmb_ptype
            // 
            this.cmb_ptype.FormattingEnabled = true;
            this.cmb_ptype.Items.AddRange(new object[] {
            "Day Blast",
            "Night Blast"});
            this.cmb_ptype.Location = new System.Drawing.Point(264, 68);
            this.cmb_ptype.Name = "cmb_ptype";
            this.cmb_ptype.Size = new System.Drawing.Size(121, 24);
            this.cmb_ptype.TabIndex = 7;
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(66, 306);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(75, 23);
            this.btn_cal.TabIndex = 8;
            this.btn_cal.Text = "Calculate";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(264, 306);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(438, 306);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 10;
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
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.cmb_ptype);
            this.Controls.Add(this.txt_tot);
            this.Controls.Add(this.txt_night);
            this.Controls.Add(this.txt_day);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_day;
        private System.Windows.Forms.TextBox txt_night;
        private System.Windows.Forms.TextBox txt_tot;
        private System.Windows.Forms.ComboBox cmb_ptype;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
    }
}


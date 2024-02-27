namespace WindowsFormsApp3
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
            this.lbl_cus = new System.Windows.Forms.Label();
            this.lbl_uni = new System.Windows.Forms.Label();
            this.lbl_tot = new System.Windows.Forms.Label();
            this.cmb_cus = new System.Windows.Forms.ComboBox();
            this.txt_uni = new System.Windows.Forms.TextBox();
            this.txt_tot = new System.Windows.Forms.TextBox();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_cls = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_cus
            // 
            this.lbl_cus.AutoSize = true;
            this.lbl_cus.Location = new System.Drawing.Point(50, 51);
            this.lbl_cus.Name = "lbl_cus";
            this.lbl_cus.Size = new System.Drawing.Size(102, 16);
            this.lbl_cus.TabIndex = 0;
            this.lbl_cus.Text = "Customer  Type";
            // 
            // lbl_uni
            // 
            this.lbl_uni.AutoSize = true;
            this.lbl_uni.Location = new System.Drawing.Point(54, 137);
            this.lbl_uni.Name = "lbl_uni";
            this.lbl_uni.Size = new System.Drawing.Size(37, 16);
            this.lbl_uni.TabIndex = 1;
            this.lbl_uni.Text = "Units";
            this.lbl_uni.Click += new System.EventHandler(this.lbl_uni_Click);
            // 
            // lbl_tot
            // 
            this.lbl_tot.AutoSize = true;
            this.lbl_tot.Location = new System.Drawing.Point(53, 213);
            this.lbl_tot.Name = "lbl_tot";
            this.lbl_tot.Size = new System.Drawing.Size(38, 16);
            this.lbl_tot.TabIndex = 2;
            this.lbl_tot.Text = "Total";
            // 
            // cmb_cus
            // 
            this.cmb_cus.FormattingEnabled = true;
            this.cmb_cus.Items.AddRange(new object[] {
            "Domestic",
            "Business"});
            this.cmb_cus.Location = new System.Drawing.Point(429, 43);
            this.cmb_cus.Name = "cmb_cus";
            this.cmb_cus.Size = new System.Drawing.Size(121, 24);
            this.cmb_cus.TabIndex = 3;
            // 
            // txt_uni
            // 
            this.txt_uni.Location = new System.Drawing.Point(429, 134);
            this.txt_uni.Name = "txt_uni";
            this.txt_uni.Size = new System.Drawing.Size(121, 22);
            this.txt_uni.TabIndex = 4;
            // 
            // txt_tot
            // 
            this.txt_tot.Location = new System.Drawing.Point(429, 207);
            this.txt_tot.Name = "txt_tot";
            this.txt_tot.Size = new System.Drawing.Size(121, 22);
            this.txt_tot.TabIndex = 5;
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(126, 403);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(96, 23);
            this.btn_cal.TabIndex = 6;
            this.btn_cal.Text = "Calculate";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // btn_cls
            // 
            this.btn_cls.Location = new System.Drawing.Point(332, 403);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(75, 23);
            this.btn_cls.TabIndex = 7;
            this.btn_cls.Text = "Clear";
            this.btn_cls.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(581, 403);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.green_leaf_and_energy_saving_lamps_vector_18_9115;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_cls);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.txt_tot);
            this.Controls.Add(this.txt_uni);
            this.Controls.Add(this.cmb_cus);
            this.Controls.Add(this.lbl_tot);
            this.Controls.Add(this.lbl_uni);
            this.Controls.Add(this.lbl_cus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cus;
        private System.Windows.Forms.Label lbl_uni;
        private System.Windows.Forms.Label lbl_tot;
        private System.Windows.Forms.ComboBox cmb_cus;
        private System.Windows.Forms.TextBox txt_uni;
        private System.Windows.Forms.TextBox txt_tot;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_cls;
        private System.Windows.Forms.Button btn_exit;
    }
}


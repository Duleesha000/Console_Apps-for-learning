namespace WindowsFormsApp7
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_show = new System.Windows.Forms.Label();
            this.btn_signin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Name:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(227, 114);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 22);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_show
            // 
            this.lbl_show.AutoSize = true;
            this.lbl_show.Location = new System.Drawing.Point(214, 264);
            this.lbl_show.Name = "lbl_show";
            this.lbl_show.Size = new System.Drawing.Size(107, 16);
            this.lbl_show.TabIndex = 2;
            this.lbl_show.Text = "********************";
            // 
            // btn_signin
            // 
            this.btn_signin.Location = new System.Drawing.Point(204, 199);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(75, 31);
            this.btn_signin.TabIndex = 3;
            this.btn_signin.Text = "Sign In";
            this.btn_signin.UseVisualStyleBackColor = true;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.lbl_show);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_show;
        private System.Windows.Forms.Button btn_signin;
    }
}


namespace Muntinlupa_Bus_E_Wallet
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserUi = new System.Windows.Forms.PictureBox();
            this.AdminLogin = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserUi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UserUi);
            this.panel1.Controls.Add(this.AdminLogin);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 375);
            this.panel1.TabIndex = 7;
            // 
            // UserUi
            // 
            this.UserUi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserUi.Location = new System.Drawing.Point(381, 46);
            this.UserUi.Name = "UserUi";
            this.UserUi.Size = new System.Drawing.Size(192, 181);
            this.UserUi.TabIndex = 18;
            this.UserUi.TabStop = false;
            this.UserUi.Click += new System.EventHandler(this.UserUi_Click);
            // 
            // AdminLogin
            // 
            this.AdminLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AdminLogin.Location = new System.Drawing.Point(54, 46);
            this.AdminLogin.Name = "AdminLogin";
            this.AdminLogin.Size = new System.Drawing.Size(192, 181);
            this.AdminLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AdminLogin.TabIndex = 17;
            this.AdminLogin.TabStop = false;
            this.AdminLogin.Click += new System.EventHandler(this.AdminLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(258, 287);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 42);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 375);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserUi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox UserUi;
        private System.Windows.Forms.PictureBox AdminLogin;
        private System.Windows.Forms.Button btnClose;
    }
}

namespace UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola";
            // 
            // tbAccountName
            // 
            this.tbAccountName.BackColor = System.Drawing.Color.White;
            this.tbAccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAccountName.Location = new System.Drawing.Point(126, 83);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Size = new System.Drawing.Size(141, 23);
            this.tbAccountName.TabIndex = 2;
            // 
            // TbPassword
            // 
            this.TbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPassword.Location = new System.Drawing.Point(126, 120);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '*';
            this.TbPassword.Size = new System.Drawing.Size(141, 23);
            this.TbPassword.TabIndex = 3;
            this.TbPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.Location = new System.Drawing.Point(153, 163);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogin.Size = new System.Drawing.Size(124, 39);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Kullanıcı Giriş";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdminLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdminLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAdminLogin.FlatAppearance.BorderSize = 0;
            this.btnAdminLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdminLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogin.ForeColor = System.Drawing.Color.White;
            this.btnAdminLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminLogin.Image")));
            this.btnAdminLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminLogin.Location = new System.Drawing.Point(25, 163);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdminLogin.Size = new System.Drawing.Size(122, 39);
            this.btnAdminLogin.TabIndex = 5;
            this.btnAdminLogin.Text = "Yönetici Giriş";
            this.btnAdminLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegister.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnRegister.FlatAppearance.BorderSize = 0;
            this.BtnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.ForeColor = System.Drawing.Color.White;
            this.BtnRegister.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegister.Image")));
            this.BtnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegister.Location = new System.Drawing.Point(-4, 1);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnRegister.Size = new System.Drawing.Size(319, 41);
            this.BtnRegister.TabIndex = 7;
            this.BtnRegister.Text = "Kayıt Olmak İçin Tıklayınız";
            this.BtnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kullanıcı Adı ve Şifrenizi giriniz...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(76, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kullanıcı Ad";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(53)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(312, 214);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.tbAccountName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAccountName;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
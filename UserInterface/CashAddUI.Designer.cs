
namespace UserInterface
{
    partial class CashAddUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashAddUI));
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_UnitMoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.Cb_UnitMoney = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lb_CalculateMoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Yüklenecek Tutar";
            // 
            // Tb_UnitMoney
            // 
            this.Tb_UnitMoney.BackColor = System.Drawing.Color.White;
            this.Tb_UnitMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_UnitMoney.Location = new System.Drawing.Point(26, 69);
            this.Tb_UnitMoney.Name = "Tb_UnitMoney";
            this.Tb_UnitMoney.Size = new System.Drawing.Size(119, 23);
            this.Tb_UnitMoney.TabIndex = 14;
            this.Tb_UnitMoney.TextChanged += new System.EventHandler(this.Tb_UnitMoney_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Yüklenecek tutarı giriniz.";
            // 
            // BtnBuy
            // 
            this.BtnBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuy.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBuy.FlatAppearance.BorderSize = 0;
            this.BtnBuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnBuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.BtnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBuy.ForeColor = System.Drawing.Color.White;
            this.BtnBuy.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuy.Image")));
            this.BtnBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuy.Location = new System.Drawing.Point(-1, 119);
            this.BtnBuy.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnBuy.Size = new System.Drawing.Size(308, 39);
            this.BtnBuy.TabIndex = 16;
            this.BtnBuy.Text = "Gönder";
            this.BtnBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuy.UseVisualStyleBackColor = false;
            this.BtnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // Cb_UnitMoney
            // 
            this.Cb_UnitMoney.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cb_UnitMoney.FormattingEnabled = true;
            this.Cb_UnitMoney.Location = new System.Drawing.Point(186, 69);
            this.Cb_UnitMoney.Name = "Cb_UnitMoney";
            this.Cb_UnitMoney.Size = new System.Drawing.Size(83, 23);
            this.Cb_UnitMoney.TabIndex = 17;
            this.Cb_UnitMoney.SelectedIndexChanged += new System.EventHandler(this.Cb_UnitMoney_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(186, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Birim";
            // 
            // Lb_CalculateMoney
            // 
            this.Lb_CalculateMoney.AutoSize = true;
            this.Lb_CalculateMoney.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_CalculateMoney.ForeColor = System.Drawing.SystemColors.Info;
            this.Lb_CalculateMoney.Location = new System.Drawing.Point(26, 95);
            this.Lb_CalculateMoney.Name = "Lb_CalculateMoney";
            this.Lb_CalculateMoney.Size = new System.Drawing.Size(0, 16);
            this.Lb_CalculateMoney.TabIndex = 19;
            // 
            // CashAddUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(53)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(304, 158);
            this.Controls.Add(this.Lb_CalculateMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cb_UnitMoney);
            this.Controls.Add(this.BtnBuy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_UnitMoney);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CashAddUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bakiye Ekle";
            this.Load += new System.EventHandler(this.CashAddUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_UnitMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuy;
        private System.Windows.Forms.ComboBox Cb_UnitMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lb_CalculateMoney;
    }
}

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
            this.TxCountOfProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Yüklenecek Tutar";
            // 
            // TxCountOfProduct
            // 
            this.TxCountOfProduct.BackColor = System.Drawing.Color.White;
            this.TxCountOfProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxCountOfProduct.Location = new System.Drawing.Point(174, 53);
            this.TxCountOfProduct.Name = "TxCountOfProduct";
            this.TxCountOfProduct.Size = new System.Drawing.Size(100, 16);
            this.TxCountOfProduct.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
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
            this.BtnBuy.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBuy.ForeColor = System.Drawing.Color.White;
            this.BtnBuy.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuy.Image")));
            this.BtnBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuy.Location = new System.Drawing.Point(-1, 93);
            this.BtnBuy.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnBuy.Size = new System.Drawing.Size(308, 65);
            this.BtnBuy.TabIndex = 16;
            this.BtnBuy.Text = "Gönder";
            this.BtnBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuy.UseVisualStyleBackColor = false;
            this.BtnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // CashAddUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(53)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(304, 158);
            this.Controls.Add(this.BtnBuy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxCountOfProduct);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CashAddUI";
            this.Text = "Bakiye Ekle";
            this.Load += new System.EventHandler(this.CashAddUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxCountOfProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuy;
    }
}
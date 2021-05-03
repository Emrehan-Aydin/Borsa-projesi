
namespace UserInterface
{
    partial class SaleOrderUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleOrderUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnBackUp = new System.Windows.Forms.Button();
            this.TxHead = new System.Windows.Forms.Label();
            this.DgSaleOrderDetails = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgSaleOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBackUp
            // 
            this.BtnBackUp.BackColor = System.Drawing.Color.Transparent;
            this.BtnBackUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBackUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBackUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnBackUp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBackUp.FlatAppearance.BorderSize = 0;
            this.BtnBackUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnBackUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.BtnBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackUp.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBackUp.ForeColor = System.Drawing.Color.White;
            this.BtnBackUp.Image = ((System.Drawing.Image)(resources.GetObject("BtnBackUp.Image")));
            this.BtnBackUp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBackUp.Location = new System.Drawing.Point(0, 316);
            this.BtnBackUp.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBackUp.Name = "BtnBackUp";
            this.BtnBackUp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnBackUp.Size = new System.Drawing.Size(634, 75);
            this.BtnBackUp.TabIndex = 10;
            this.BtnBackUp.Text = "Geri Al";
            this.BtnBackUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBackUp.UseVisualStyleBackColor = false;
            this.BtnBackUp.Click += new System.EventHandler(this.BtnBackUp_Click);
            // 
            // TxHead
            // 
            this.TxHead.AutoSize = true;
            this.TxHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(33)))));
            this.TxHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxHead.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxHead.ForeColor = System.Drawing.Color.White;
            this.TxHead.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TxHead.Location = new System.Drawing.Point(0, 0);
            this.TxHead.Name = "TxHead";
            this.TxHead.Size = new System.Drawing.Size(185, 32);
            this.TxHead.TabIndex = 14;
            this.TxHead.Text = "SATIM EMİRLERİ";
            this.TxHead.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DgSaleOrderDetails
            // 
            this.DgSaleOrderDetails.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DgSaleOrderDetails.AllowUserToAddRows = false;
            this.DgSaleOrderDetails.AllowUserToDeleteRows = false;
            this.DgSaleOrderDetails.AllowUserToResizeColumns = false;
            this.DgSaleOrderDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.DgSaleOrderDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgSaleOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgSaleOrderDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(53)))));
            this.DgSaleOrderDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgSaleOrderDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgSaleOrderDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgSaleOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgSaleOrderDetails.ColumnHeadersHeight = 25;
            this.DgSaleOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgSaleOrderDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgSaleOrderDetails.EnableHeadersVisualStyles = false;
            this.DgSaleOrderDetails.Location = new System.Drawing.Point(0, 40);
            this.DgSaleOrderDetails.MultiSelect = false;
            this.DgSaleOrderDetails.Name = "DgSaleOrderDetails";
            this.DgSaleOrderDetails.ReadOnly = true;
            this.DgSaleOrderDetails.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DgSaleOrderDetails.RowHeadersVisible = false;
            this.DgSaleOrderDetails.RowHeadersWidth = 51;
            this.DgSaleOrderDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgSaleOrderDetails.RowTemplate.Height = 25;
            this.DgSaleOrderDetails.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DgSaleOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgSaleOrderDetails.Size = new System.Drawing.Size(634, 270);
            this.DgSaleOrderDetails.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(33)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 34);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // SaleOrderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(53)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 391);
            this.Controls.Add(this.TxHead);
            this.Controls.Add(this.DgSaleOrderDetails);
            this.Controls.Add(this.BtnBackUp);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SaleOrderUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SaleOrderPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaleOrderUI_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SaleOrderUI_FormClosed);
            this.Load += new System.EventHandler(this.SaleOrderUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgSaleOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnBackUp;
        private System.Windows.Forms.Label TxHead;
        private System.Windows.Forms.DataGridView DgSaleOrderDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
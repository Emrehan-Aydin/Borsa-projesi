
namespace UserInterface
{
    partial class CashConfirmationUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashConfirmationUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnConfirmation = new System.Windows.Forms.Button();
            this.TxHead = new System.Windows.Forms.Label();
            this.DwCashConfirmation = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DwCashConfirmation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConfirmation
            // 
            this.BtnConfirmation.BackColor = System.Drawing.Color.Transparent;
            this.BtnConfirmation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnConfirmation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfirmation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnConfirmation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnConfirmation.FlatAppearance.BorderSize = 0;
            this.BtnConfirmation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnConfirmation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.BtnConfirmation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmation.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConfirmation.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmation.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfirmation.Image")));
            this.BtnConfirmation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfirmation.Location = new System.Drawing.Point(0, 316);
            this.BtnConfirmation.Margin = new System.Windows.Forms.Padding(0);
            this.BtnConfirmation.Name = "BtnConfirmation";
            this.BtnConfirmation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnConfirmation.Size = new System.Drawing.Size(634, 75);
            this.BtnConfirmation.TabIndex = 11;
            this.BtnConfirmation.Text = "İşlemi Onayla";
            this.BtnConfirmation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmation.UseVisualStyleBackColor = false;
            this.BtnConfirmation.Click += new System.EventHandler(this.BtnConfirmation_Click);
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
            this.TxHead.Size = new System.Drawing.Size(238, 32);
            this.TxHead.TabIndex = 16;
            this.TxHead.Text = "BAKİYE ONAY LİSTESİ";
            this.TxHead.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DwCashConfirmation
            // 
            this.DwCashConfirmation.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DwCashConfirmation.AllowUserToAddRows = false;
            this.DwCashConfirmation.AllowUserToDeleteRows = false;
            this.DwCashConfirmation.AllowUserToResizeColumns = false;
            this.DwCashConfirmation.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.DwCashConfirmation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DwCashConfirmation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DwCashConfirmation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(53)))));
            this.DwCashConfirmation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DwCashConfirmation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DwCashConfirmation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DwCashConfirmation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DwCashConfirmation.ColumnHeadersHeight = 25;
            this.DwCashConfirmation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DwCashConfirmation.DefaultCellStyle = dataGridViewCellStyle3;
            this.DwCashConfirmation.EnableHeadersVisualStyles = false;
            this.DwCashConfirmation.Location = new System.Drawing.Point(0, 40);
            this.DwCashConfirmation.MultiSelect = false;
            this.DwCashConfirmation.Name = "DwCashConfirmation";
            this.DwCashConfirmation.ReadOnly = true;
            this.DwCashConfirmation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DwCashConfirmation.RowHeadersVisible = false;
            this.DwCashConfirmation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DwCashConfirmation.RowTemplate.Height = 25;
            this.DwCashConfirmation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DwCashConfirmation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DwCashConfirmation.Size = new System.Drawing.Size(634, 270);
            this.DwCashConfirmation.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(33)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 34);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // CashConfirmationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(53)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 391);
            this.Controls.Add(this.TxHead);
            this.Controls.Add(this.DwCashConfirmation);
            this.Controls.Add(this.BtnConfirmation);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CashConfirmationUI";
            this.Text = "CashConfirmationUI";
            this.Load += new System.EventHandler(this.CashConfirmationUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DwCashConfirmation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnConfirmation;
        private System.Windows.Forms.Label TxHead;
        private System.Windows.Forms.DataGridView DwCashConfirmation;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

namespace UserInterface
{
    partial class ProductConfirmationUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductConfirmationUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnConfirmation = new System.Windows.Forms.Button();
            this.TxHead = new System.Windows.Forms.Label();
            this.DwProductConfirmation = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DwProductConfirmation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConfirmation
            // 
            this.BtnConfirmation.BackColor = System.Drawing.Color.Transparent;
            this.BtnConfirmation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConfirmation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfirmation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnConfirmation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnConfirmation.FlatAppearance.BorderSize = 0;
            this.BtnConfirmation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnConfirmation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.BtnConfirmation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmation.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConfirmation.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmation.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfirmation.Image")));
            this.BtnConfirmation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfirmation.Location = new System.Drawing.Point(0, 316);
            this.BtnConfirmation.Margin = new System.Windows.Forms.Padding(0);
            this.BtnConfirmation.Name = "BtnConfirmation";
            this.BtnConfirmation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnConfirmation.Size = new System.Drawing.Size(684, 75);
            this.BtnConfirmation.TabIndex = 10;
            this.BtnConfirmation.Text = "İşlemi Onayla";
            this.BtnConfirmation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmation.UseVisualStyleBackColor = false;
            this.BtnConfirmation.Click += new System.EventHandler(this.BtnConfirmation_Click);
            // 
            // TxHead
            // 
            this.TxHead.AutoSize = true;
            this.TxHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(33)))));
            this.TxHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxHead.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxHead.ForeColor = System.Drawing.Color.White;
            this.TxHead.Image = ((System.Drawing.Image)(resources.GetObject("TxHead.Image")));
            this.TxHead.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TxHead.Location = new System.Drawing.Point(10, 14);
            this.TxHead.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.TxHead.Name = "TxHead";
            this.TxHead.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxHead.Size = new System.Drawing.Size(167, 25);
            this.TxHead.TabIndex = 20;
            this.TxHead.Text = "      VARLIK İŞLEMLERİ";
            this.TxHead.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TxHead.UseCompatibleTextRendering = true;
            // 
            // DwProductConfirmation
            // 
            this.DwProductConfirmation.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DwProductConfirmation.AllowUserToAddRows = false;
            this.DwProductConfirmation.AllowUserToDeleteRows = false;
            this.DwProductConfirmation.AllowUserToResizeColumns = false;
            this.DwProductConfirmation.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.DwProductConfirmation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DwProductConfirmation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DwProductConfirmation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(53)))));
            this.DwProductConfirmation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DwProductConfirmation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DwProductConfirmation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DwProductConfirmation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DwProductConfirmation.ColumnHeadersHeight = 45;
            this.DwProductConfirmation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DwProductConfirmation.DefaultCellStyle = dataGridViewCellStyle3;
            this.DwProductConfirmation.EnableHeadersVisualStyles = false;
            this.DwProductConfirmation.Location = new System.Drawing.Point(0, 55);
            this.DwProductConfirmation.MultiSelect = false;
            this.DwProductConfirmation.Name = "DwProductConfirmation";
            this.DwProductConfirmation.ReadOnly = true;
            this.DwProductConfirmation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DwProductConfirmation.RowHeadersVisible = false;
            this.DwProductConfirmation.RowHeadersWidth = 51;
            this.DwProductConfirmation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DwProductConfirmation.RowTemplate.Height = 45;
            this.DwProductConfirmation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DwProductConfirmation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DwProductConfirmation.Size = new System.Drawing.Size(684, 255);
            this.DwProductConfirmation.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(33)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 55);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // ProductConfirmationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(53)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(684, 391);
            this.Controls.Add(this.TxHead);
            this.Controls.Add(this.DwProductConfirmation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnConfirmation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProductConfirmationUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Varlık İşlemleri";
            this.Load += new System.EventHandler(this.ProductConfirmationUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DwProductConfirmation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnConfirmation;
        private System.Windows.Forms.Label TxHead;
        private System.Windows.Forms.DataGridView DwProductConfirmation;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
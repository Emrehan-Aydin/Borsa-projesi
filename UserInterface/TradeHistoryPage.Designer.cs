
namespace UserInterface
{
    partial class TradeHistoryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TradeHistoryPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxHead = new System.Windows.Forms.Label();
            this.Dw_tradeHistory = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_WriteReport = new System.Windows.Forms.Button();
            this.Cb_ListFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirtDatePicker = new System.Windows.Forms.DateTimePicker();
            this.LastDatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Dw_tradeHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.TxHead.Size = new System.Drawing.Size(208, 25);
            this.TxHead.TabIndex = 27;
            this.TxHead.Text = "      ALIM - SATIM GEÇMİŞİ";
            this.TxHead.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TxHead.UseCompatibleTextRendering = true;
            // 
            // Dw_tradeHistory
            // 
            this.Dw_tradeHistory.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Dw_tradeHistory.AllowUserToAddRows = false;
            this.Dw_tradeHistory.AllowUserToDeleteRows = false;
            this.Dw_tradeHistory.AllowUserToResizeColumns = false;
            this.Dw_tradeHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.Dw_tradeHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dw_tradeHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dw_tradeHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(53)))));
            this.Dw_tradeHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dw_tradeHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dw_tradeHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dw_tradeHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dw_tradeHistory.ColumnHeadersHeight = 45;
            this.Dw_tradeHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dw_tradeHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dw_tradeHistory.EnableHeadersVisualStyles = false;
            this.Dw_tradeHistory.Location = new System.Drawing.Point(0, 55);
            this.Dw_tradeHistory.MultiSelect = false;
            this.Dw_tradeHistory.Name = "Dw_tradeHistory";
            this.Dw_tradeHistory.ReadOnly = true;
            this.Dw_tradeHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dw_tradeHistory.RowHeadersVisible = false;
            this.Dw_tradeHistory.RowHeadersWidth = 51;
            this.Dw_tradeHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dw_tradeHistory.RowTemplate.Height = 45;
            this.Dw_tradeHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dw_tradeHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dw_tradeHistory.Size = new System.Drawing.Size(1549, 578);
            this.Dw_tradeHistory.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(33)))));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1549, 55);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // Btn_WriteReport
            // 
            this.Btn_WriteReport.BackColor = System.Drawing.Color.Transparent;
            this.Btn_WriteReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_WriteReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_WriteReport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_WriteReport.FlatAppearance.BorderSize = 0;
            this.Btn_WriteReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_WriteReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.Btn_WriteReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_WriteReport.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_WriteReport.ForeColor = System.Drawing.Color.White;
            this.Btn_WriteReport.Image = ((System.Drawing.Image)(resources.GetObject("Btn_WriteReport.Image")));
            this.Btn_WriteReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_WriteReport.Location = new System.Drawing.Point(1424, 0);
            this.Btn_WriteReport.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_WriteReport.Name = "Btn_WriteReport";
            this.Btn_WriteReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_WriteReport.Size = new System.Drawing.Size(125, 55);
            this.Btn_WriteReport.TabIndex = 25;
            this.Btn_WriteReport.Text = "   Yazdır ";
            this.Btn_WriteReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_WriteReport.UseVisualStyleBackColor = false;
            this.Btn_WriteReport.Click += new System.EventHandler(this.Btn_WriteReport_Click);
            // 
            // Cb_ListFilter
            // 
            this.Cb_ListFilter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cb_ListFilter.FormattingEnabled = true;
            this.Cb_ListFilter.Items.AddRange(new object[] {
            "SADECE ALIM GEÇMİŞİ",
            "SADECE SATIŞ GEÇMİŞİ",
            "HEM ALIŞ HEM SATIŞ GEÇMİŞİ"});
            this.Cb_ListFilter.Location = new System.Drawing.Point(427, 14);
            this.Cb_ListFilter.Name = "Cb_ListFilter";
            this.Cb_ListFilter.Size = new System.Drawing.Size(263, 29);
            this.Cb_ListFilter.TabIndex = 29;
            this.Cb_ListFilter.SelectedIndexChanged += new System.EventHandler(this.Cb_ListFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(33)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(354, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "FİLTRELE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(33)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(760, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Başlangıç Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(33)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1134, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Bitiş Tarihi";
            // 
            // FirtDatePicker
            // 
            this.FirtDatePicker.Location = new System.Drawing.Point(909, 16);
            this.FirtDatePicker.MaxDate = new System.DateTime(2031, 1, 5, 0, 0, 0, 0);
            this.FirtDatePicker.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.FirtDatePicker.Name = "FirtDatePicker";
            this.FirtDatePicker.Size = new System.Drawing.Size(180, 23);
            this.FirtDatePicker.TabIndex = 36;
            this.FirtDatePicker.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.FirtDatePicker.ValueChanged += new System.EventHandler(this.FirtDatePicker_ValueChanged);
            // 
            // LastDatePicker
            // 
            this.LastDatePicker.Location = new System.Drawing.Point(1234, 16);
            this.LastDatePicker.Name = "LastDatePicker";
            this.LastDatePicker.Size = new System.Drawing.Size(180, 23);
            this.LastDatePicker.TabIndex = 37;
            this.LastDatePicker.ValueChanged += new System.EventHandler(this.LastDatePicker_ValueChanged);
            // 
            // TradeHistoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1548, 645);
            this.Controls.Add(this.LastDatePicker);
            this.Controls.Add(this.FirtDatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_WriteReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cb_ListFilter);
            this.Controls.Add(this.TxHead);
            this.Controls.Add(this.Dw_tradeHistory);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TradeHistoryPage";
            this.Text = "TradeHistoryPage";
            this.Load += new System.EventHandler(this.TradeHistoryPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dw_tradeHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxHead;
        private System.Windows.Forms.DataGridView Dw_tradeHistory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_WriteReport;
        private System.Windows.Forms.ComboBox Cb_ListFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FirtDatePicker;
        private System.Windows.Forms.DateTimePicker LastDatePicker;
    }
}
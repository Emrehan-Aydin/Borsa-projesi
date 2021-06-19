using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTo;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class TradeHistoryPage : Form
    {
        ShopHistoryManager shopHistoryManarger = new ShopHistoryManager(new EfShopHistoryDal());
        Account _account;
        List<TradeHistoryDetailsDto> result;
        public TradeHistoryPage(Account account)
        {
            _account = account;
            result = shopHistoryManarger.GetDetails(account.Id).Data;
            InitializeComponent();
            Cb_ListFilter.SelectedIndex = 2;
        }

        private void TradeHistoryPage_Load(object sender, EventArgs e)
        {
            Dw_tradeHistory.DataSource = result;
            Dw_tradeHistory.Columns[0].HeaderText = "Tarih";
            Dw_tradeHistory.Columns[1].HeaderText = "Alıcı UID";
            Dw_tradeHistory.Columns[2].HeaderText = "Alıcı Ad";
            Dw_tradeHistory.Columns[3].HeaderText = "Alıcı Soyad";
            Dw_tradeHistory.Columns[4].HeaderText = "Satıcı UID";
            Dw_tradeHistory.Columns[5].HeaderText = "Satıcı Ad";
            Dw_tradeHistory.Columns[6].HeaderText = "Satıcı Soyad";
            Dw_tradeHistory.Columns[7].HeaderText = "Ürün";
            Dw_tradeHistory.Columns[8].HeaderText = "Miktar";
            Dw_tradeHistory.Columns[9].HeaderText = "Toplam Tutar";
            Dw_tradeHistory.Columns[10].HeaderText = "Komisyon";
        }

        private void GetDgwData(List<TradeHistoryDetailsDto> Filterresult)
        {
            Dw_tradeHistory.DataSource = Filterresult;
        }
        private void FilterDoDgwData()
        {
            if (Cb_ListFilter.SelectedIndex == 0)
            {
                GetDgwData(result.Where(R => R.BuyerUID == _account.Id && R.Date >= FirtDatePicker.Value && R.Date <= LastDatePicker.Value).ToList());
            }
            else if (Cb_ListFilter.SelectedIndex == 1)
            {
                GetDgwData(result.Where(R => R.SellerUID == _account.Id && R.Date >= FirtDatePicker.Value && R.Date <= LastDatePicker.Value).ToList());
            }
            else if (Cb_ListFilter.SelectedIndex == 2)
            {
                GetDgwData(result.Where(R => R.Date >= FirtDatePicker.Value && R.Date <= LastDatePicker.Value).ToList());
            }
            else
            {
                GetDgwData(result.Where(R => R.Date >= FirtDatePicker.Value && R.Date <= LastDatePicker.Value).ToList());
            }
        }
        private void Cb_ListFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDoDgwData();
        }
        private void FirtDatePicker_ValueChanged(object sender, EventArgs e)
        {
            FilterDoDgwData();
        }
        private void LastDatePicker_ValueChanged(object sender, EventArgs e)
        {
            FilterDoDgwData();
        }

        private void Btn_WriteReport_Click(object sender, EventArgs e)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            iTextSharp.text.Font times = new iTextSharp.text.Font(bf);
            PdfPTable pdfPTable = new PdfPTable(Dw_tradeHistory.Columns.Count);
            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth = 1;

            foreach (DataGridViewColumn item in Dw_tradeHistory.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(item.HeaderText));
                pdfPTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in Dw_tradeHistory.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfPTable.AddCell(new Phrase(cell.Value.ToString()));
                }
            }

            var saveFiledialog = new SaveFileDialog();
            saveFiledialog.DefaultExt = ".pdf";
            if (saveFiledialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFiledialog.FileName, FileMode.Create))
                {
                    Document pdfDosya = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDosya, stream);
                    pdfDosya.Open();
                    Jpeg resim = new Jpeg(new Uri(@"C:\Users\emreh\source\repos\Emrehan-Aydin\Borsa-projesi\logo.jpg"));
                    resim.Alignment = 1;
                    Paragraph description = new Paragraph(FirtDatePicker.Value + " - " + LastDatePicker.Value + " Tarihleri Arasındaki " + Cb_ListFilter.SelectedItem.ToString() , times);
                    description.Alignment = 1;
                    pdfDosya.Add(resim);
                    pdfDosya.Add(description);
                    pdfDosya.Add(new Paragraph(" "));
                    pdfDosya.Add(pdfPTable);
                    pdfDosya.Close();
                    stream.Close();
                }
            }
        }
    }
}

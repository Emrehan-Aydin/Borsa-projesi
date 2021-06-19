using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Entities.Concrete;
using Entities.DTo;

namespace UserInterface
{
    public partial class PurchaseOrderUI : Form
    {
        PurchaseOrderManager purchaseOrderManager = new PurchaseOrderManager(new EfPurchaseOrderDal());
        AccountAsset accountAsset = new AccountAsset();
        Account _account;

        public PurchaseOrderUI(Account account)
        {
            // İlgili account nesnesi
            _account = account;
            // Alım emirleri hesaba göre Dto verilerinin çekilmesi.
            InitializeComponent();
        }

        public PurchaseOrderUI()
        {
            // Alım emirleri tüm Dto verilerinin çekilmesi
            InitializeComponent();
        }

        private void PurchaseOrderUI_Load(object sender, EventArgs e)
        {
            if (_account == null)
            {
                GetAdminDwDatas(); // DatagridviEw admin için tüm verileri çeker
            }
            else
            {
                GetDwDatas(); // DatagridView Verileri getir fonksiyonu
            }
        }

        private void GetDwDatas()
        {
            // Dto  Aktar
            DwPurchaseOrder.DataSource = purchaseOrderManager.GetByAccountDetail(_account).Data;
            // Dgw başlıklar set edilmesi
            DwPurchaseOrder.Columns[0].Visible = false;
            DwPurchaseOrder.Columns[1].HeaderText = "Ürün Adı";
            DwPurchaseOrder.Columns[2].HeaderText = "Birim Fiyat";
            DwPurchaseOrder.Columns[3].HeaderText = "Adet";
            DwPurchaseOrder.Columns[4].HeaderText = "User Id";
            DwPurchaseOrder.Columns[5].HeaderText = "Ad";
            DwPurchaseOrder.Columns[6].HeaderText = "Soyad";
        }
        private void GetAdminDwDatas()
        {
            // Dto  Aktar
            DwPurchaseOrder.DataSource = purchaseOrderManager.GetPurchaseOrderDetail().Data;
            // Dgw başlıklar set edilmesi
            DwPurchaseOrder.Columns[0].Visible = false;
            DwPurchaseOrder.Columns[1].HeaderText = "Ürün Adı";
            DwPurchaseOrder.Columns[2].HeaderText = "Birim Fiyat";
            DwPurchaseOrder.Columns[3].HeaderText = "Adet";
            DwPurchaseOrder.Columns[4].HeaderText = "User Id";
            DwPurchaseOrder.Columns[5].HeaderText = "Ad";
            DwPurchaseOrder.Columns[6].HeaderText = "Soyad";
        }

        private void BtnBackUp_Click(object sender, EventArgs e)
        {
            PurchaseBackup();// GeriAl Fonksiyonu
        }

        private void PurchaseBackup()
        {
            // Seçili işlemin geri iade işlemi
            var result = purchaseOrderManager.GetById(Convert.ToInt32(DwPurchaseOrder.SelectedCells[0].Value)).Data;
            accountAsset.AccountId = result.BuyerId;
            accountAsset.ProductId = result.ProductId;
            accountAsset.ProductOfStock += result.Count;
            purchaseOrderManager.Delete(result);
            // Seçili ürün geri iade sistem mesajı
            MessageBox.Show(DwPurchaseOrder.SelectedCells[3].Value + " Adet " + DwPurchaseOrder.SelectedCells[1].Value + " Ürün geri iade edilmiştir.", "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (_account == null)
            {
                GetAdminDwDatas(); // DatagridviEw admin için tüm verileri çeker
                
            }
            else
            {
                GetDwDatas(); // DatagridView Verileri getir fonksiyonu
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

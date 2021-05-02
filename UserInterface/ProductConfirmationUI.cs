using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class ProductConfirmationUI : Form
    {
        ProductConfirmationManager productConfirmationManager = new ProductConfirmationManager(new EfProductConfirmationDal());
        public ProductConfirmationUI()
        {
            InitializeComponent();
        }

        private void ProductConfirmationUI_Load(object sender, EventArgs e)
        {
            // Dgw Data çekme fonksiyonu 
            GetDataGW();
        }

        private void GetDataGW()
        {
            // DGW dto aktarma 
            DwProductConfirmation.DataSource = productConfirmationManager.GetProductsConfirmationDetail().Data;
            //DGW başlıklar set edilmesi
            DwProductConfirmation.Columns[0].HeaderText = "İşlem Id";
            DwProductConfirmation.Columns[1].HeaderText = "Kimlik Nu";
            DwProductConfirmation.Columns[2].HeaderText = "Ad";
            DwProductConfirmation.Columns[3].HeaderText = "Soyad";
            DwProductConfirmation.Columns[4].HeaderText = "Ürün Ad";
            DwProductConfirmation.Columns[5].HeaderText = "Miktar";
        }
        private void BtnConfirmation_Click(object sender, EventArgs e)
        {
            // işlem Id si alınarak işlem detayları alınır

            int ConfirmId = Convert.ToInt32(DwProductConfirmation.SelectedCells[0].Value);
            ProductsConfirmation productConfirmation = productConfirmationManager.GetById(ConfirmId).Data;
            AccountAssetManager assetManager = new AccountAssetManager(new EfAccountAssetDal());
            AccountAsset accountAsset = new AccountAsset();

            //Eklenecek Ürün bilgileri ve i
            accountAsset.AccountId = productConfirmation.AccountId;
            accountAsset.ProductId = productConfirmation.ProductId;
            accountAsset.ProductOfStock = productConfirmation.CountOfProduct;

            // Ürün ilgili kullanıcıya eklenerek, ilgili onay silinir.

            assetManager.Add(accountAsset);
            productConfirmationManager.Delete(productConfirmation);

            //Listenin güncel hali
            GetDataGW();
        }
    }
}

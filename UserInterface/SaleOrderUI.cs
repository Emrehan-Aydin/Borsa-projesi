using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Entities.DTo;

namespace UserInterface
{
    public partial class SaleOrderUI : Form
    {
        SaleOrderManager saleOrderManager = new SaleOrderManager(new EfSaleOrderDal());
        List<SaleOrderDto> saleOrderDto;
        Account _account;
        public SaleOrderUI(Account account)
        {
            InitializeComponent();
            _account = account;
            saleOrderDto = saleOrderManager.GetByAccountDetails(account).Data;
        }
        public SaleOrderUI()
        {
            InitializeComponent();
        }
        private void SaleOrderUI_Load(object sender, EventArgs e)
        {
            GetDataGridView(); 
        }

        private void GetDataGridView()
        {
            DgSaleOrderDetails.DataSource = saleOrderManager.GetDetails().Data; ;
            DgSaleOrderDetails.Columns[0].HeaderText = "İşlem Id";
            DgSaleOrderDetails.Columns[1].HeaderText = "Ürün Adı";
            DgSaleOrderDetails.Columns[2].HeaderText = "Birim fiyat";
            DgSaleOrderDetails.Columns[3].HeaderText = "Adet";
            DgSaleOrderDetails.Columns[4].HeaderText = "UId";
            DgSaleOrderDetails.Columns[5].HeaderText = "Ad";
            DgSaleOrderDetails.Columns[6].HeaderText = "Soyad";
        }

        private void BtnBackUp_Click(object sender, EventArgs e)
        {
            SaleBackup();
        }
        private void SaleBackup()
        {
            var result = saleOrderManager.GetById(Convert.ToInt32(DgSaleOrderDetails.SelectedCells[0].Value)).Data;
            AccountAsset accountAsset = new AccountAsset();
            AccountAssetManager accountAssetManager = new AccountAssetManager(new EfAccountAssetDal());
            accountAsset.AccountId = result.SellerId;
            accountAsset.ProductId = result.ProductId;
            accountAsset.ProductOfStock += result.StockOfProduct;
            accountAssetManager.Add(accountAsset);
            saleOrderManager.Delete(result);
            MessageBox.Show(DgSaleOrderDetails.SelectedCells[3].Value+" Adet "+DgSaleOrderDetails.SelectedCells[1].Value +" Ürün geri iade edilmiştir.", "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var mfrm = (UserIndexUI)Application.OpenForms["UserIndexUI"];
            if (mfrm != null)
                mfrm.GetUserInterfaceInfo();
            GetDataGridView();
        }

        private void SaleOrderUI_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void SaleOrderUI_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

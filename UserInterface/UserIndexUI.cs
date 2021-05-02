using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using ShopBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class UserIndexUI : Form
    {
        // Account için varlık nesneleri
        Account _account;
        AccountAsset accountAsset = new AccountAsset();
        AccountFinance accountFinance = new AccountFinance();
        AccountInformation accountInformation = new AccountInformation();
        // Account varlık nesnelerinin yönetilmesi için gerekli nesneler
        AccountAssetManager accountAssetManager = new AccountAssetManager(new EfAccountAssetDal());
        AccountFinanceManager accountFinanceManager = new AccountFinanceManager(new EfAccountFinanceDal());
        AccountInformationManager accountInformationManager = new AccountInformationManager(new EfAccountInformationDal());
        ProductManager productManager = new ProductManager(new EfProductDal());

        public UserIndexUI(Account account)
        {
            // Giriş yapan kullanıcı Hesap bilgileri
            InitializeComponent();
            _account = account;
        }

        private void UserIndexUI_Load(object sender, EventArgs e)
        {
            // Arayüzdeki bilgilerin çekilmesi
            GetUserInterfaceInfo();
            GetCbData();
        }

        private void BtnBakiyeEkle_Click(object sender, EventArgs e)
        {
            // Bakiye ekleme işlemi form nesnesi
            CashAddUI cashAddUI = new CashAddUI(_account.Id); 
            cashAddUI.ShowDialog();
        }

        private void BtnNewProduct_Click(object sender, EventArgs e)
        {
            // Yeni Ürün ekleme Form Nesnesi
            AddNewProductUI addNewProductUI = new AddNewProductUI(productManager, _account.Id);
            addNewProductUI.ShowDialog();
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            // Satın Al emir fonksiyonu
            BuyProduct();
        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            // Sat emir fonksiyonu
            SellProduct();
        }

        private void BtnSaleHistory_Click(object sender, EventArgs e)
        {
            SaleOrderUI saleOrderUI = new SaleOrderUI(_account); // Satım formu nesnesi
            saleOrderUI.ShowDialog();
        }

        private void BtnPurchaseHistory_Click(object sender, EventArgs e)
        {
            PurchaseOrderUI purchaseOrderUI = new PurchaseOrderUI(_account); // Alım formu nesnesi
            purchaseOrderUI.ShowDialog();
        }

        private void SellProduct()
        {
            // Satış  için ürün nesnesi ve girdileri
            SaleOrder saleOrder = new SaleOrder();
            saleOrder.ProductId = productManager.GetAll().Data.SingleOrDefault(p => p.ProductName == CbMyProductList.SelectedItem.ToString()).Id;
            saleOrder.SellerId = _account.Id;
            saleOrder.StockOfProduct = Convert.ToInt32(TbMyProductCount.Text);
            saleOrder.UnitPrice = Convert.ToInt32(TbMyPriceOfProduct.Text);
            // Satış nesnesi yönetim nesnesi
            SaleOrderManager saleOrderManager = new SaleOrderManager(new EfSaleOrderDal());
            // Kontrol ve ekleme işlemi
            int maxvalue = accountAssetManager.GetByAccount(_account.Id).Data.SingleOrDefault(p => p.ProductId == saleOrder.ProductId).ProductOfStock;
            if (maxvalue >= Convert.ToInt32(TbMyProductCount.Text) && Convert.ToInt32(TbMyProductCount.Text) > 0)
            {
                // girdilerin database kayıt blokları
                AccountAsset accountAsset = accountAssetManager.GetByAccount(_account.Id).Data.SingleOrDefault(p => p.ProductId == saleOrder.ProductId);
                accountAsset.ProductOfStock -= Convert.ToInt32(TbMyProductCount.Text);
                saleOrderManager.Add(saleOrder);
                accountAssetManager.Update(accountAsset);
                MessageBox.Show(saleOrder.StockOfProduct + " Kg " + CbMyProductList.SelectedItem.ToString() + " için satım emri oluşturulmuştur.", "İşleminiz Alındı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Başarısız kriter hata mesajı.
                MessageBox.Show("Geçerli ürün miktarı girmediniz.", "Geçersiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Arayüz bilgileri güncelleme
            CheckShopAlgorit();
            GetUserInterfaceInfo();
        }

        public void GetUserInterfaceInfo()
        {
            //DataGridView Datası çekme
            Assets.DataSource = accountAssetManager.GetDetails(_account.Id).Data;
            Assets.Columns[0].HeaderText = "Barkod";
            Assets.Columns[1].HeaderText = "Ürün Adı";
            Assets.Columns[2].HeaderText = "Adet";
            accountInformation = accountInformationManager.GetByAccount(_account.Id).Data;
            TxBakiye.Text = accountFinanceManager.GetByAccount(_account.Id).Data.Cash.ToString() + "TL";
            TxUserName.Text = accountInformation.Name + " " + accountInformation.Surname;
        }

        public void GetCbData()
        {
            // ComboBox ürün listesi çekme
            var productlist = productManager.GetAll();
            var myproductlist = accountAssetManager.GetByAccount(_account.Id);
            foreach (var products in productlist.Data) // tüm ürünler listesi
            {
                CbProductList.Items.Add(products.ProductName);
                foreach (var myproducts in myproductlist.Data) 
                {
                    if (myproducts.ProductId == products.Id)// Sahip ürünler listesi kontrol
                    {
                        CbMyProductList.Items.Add(products.ProductName);
                    }
                }
            }
        }

        private void BuyProduct()
        {
            // Alım Ürün varlık nesnesi
            PurchaseOrder purchaseOrder = new PurchaseOrder();
            purchaseOrder.ProductId = productManager.GetAll().Data.SingleOrDefault(p => p.ProductName == CbProductList.SelectedItem.ToString()).Id;
            purchaseOrder.BuyerId = _account.Id;
            purchaseOrder.Count = Convert.ToInt32(TbProductCount.Text);
            // Alım varlık nesnesinin yönetim nesnesi ve ekleme.
            PurchaseOrderManager purchaserManager = new PurchaseOrderManager(new EfPurchaseOrderDal());
            purchaserManager.Add(purchaseOrder);
            // Onaylanan işlem sistem mesajı.
            MessageBox.Show(purchaseOrder.Count + " Kg " + CbProductList.SelectedItem.ToString() + " için alım emri oluşturulmuştur.", "İşleminiz Alındı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CheckShopAlgorit();
            GetUserInterfaceInfo();
        }
        // alım satım algoritması
        private void CheckShopAlgorit()
        {
            CheckShop checkShop = new CheckShop();
            checkShop.checkSaleAndPurchase();
        }
    }
}

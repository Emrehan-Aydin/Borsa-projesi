using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
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
    public partial class AddNewProductUI : Form
    {
        int hesapId;
        ProductManager _productManager;
        public AddNewProductUI(ProductManager productManager,int hesapId)
        {
            // İlgili hesap bilgileri
            InitializeComponent();
            this.hesapId = hesapId;
            _productManager = productManager;
    }

        private void AddNewProductUI_Load(object sender, EventArgs e)
        {
            GetProductList();//Eklenecek Tüm ürünlerin listesi 
        }

        private void GetProductList()
        {
            foreach (var products in _productManager.GetAll().Data) // ürünler nesnesini gezer
            {
                CbProductList.Items.Add(products.ProductName); // ComboBox elemanları üstüne ekler.
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Ürün ekleme onay fonksiyonu
            SendBuyInvite();
        }

        private void SendBuyInvite()
        {
            // Ürün onay varlık nesnesi oluşturulması
            ProductsConfirmation productsConfirmation = new ProductsConfirmation();
            productsConfirmation.AccountId = hesapId;
            productsConfirmation.CountOfProduct = Convert.ToInt32(TxProductOfCount.Text);
            productsConfirmation.ProductId = _productManager.GetAll().Data.SingleOrDefault(p => p.ProductName == CbProductList.SelectedItem.ToString()).Id;
            // Ürün onay varlık nesnesi yönetim nesnesi 
            ProductConfirmationManager productsConfirmationManager = new ProductConfirmationManager(new EfProductConfirmationDal());
            productsConfirmationManager.Add(productsConfirmation);
            // Ürün onay nesnesi ekleme sisem mesajı
            MessageBox.Show(CbProductList.SelectedItem.ToString() + " " + productsConfirmation.CountOfProduct + " Kg Ürün onay sepetine eklenmiştir.", "Gönderildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CbProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

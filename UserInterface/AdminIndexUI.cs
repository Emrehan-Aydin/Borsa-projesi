using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class AdminIndexUI : Form
    {
        Account _account;
        public AdminIndexUI(Account account)
        { 
            // İlgili account nesnesi 
            InitializeComponent();
            _account = account;
        }

        private void BtnSellPage_Click(object sender, EventArgs e)
        {
            // Satış ermir listesi form nesnesi
            SaleOrderUI saleOrder = new SaleOrderUI();
            GetForm(saleOrder);
            //saleOrder.ShowDialog();
        }

        private void BtnFinancePage_Click(object sender, EventArgs e)
        {
            // Para onay listesi form nesnesi
            CashConfirmationUI cashConfirmation = new CashConfirmationUI();
            GetForm(cashConfirmation);
        }

        private void BtnPurchasePage_Click(object sender, EventArgs e)
        {
            // Alım ermir listesi form nesnesi
            PurchaseOrderUI purchaseOrder = new PurchaseOrderUI();
            GetForm(purchaseOrder);
        }

        private void BtnProductPage_Click(object sender, EventArgs e)
        {
            // Ürün ekleme onay listesi form nesnesi
            ProductConfirmationUI ProductConfirmation = new ProductConfirmationUI();
            GetForm(ProductConfirmation);
        }
        private void GetForm(Form form)
        {
            panel2.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(form);
            form.Show();
        }
        private void AdminIndexUI_Load(object sender, EventArgs e)
        {
             
        }
    }
}

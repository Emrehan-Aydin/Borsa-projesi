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

namespace UserInterface
{
    public partial class CashAddUI : Form
    {
        int Id;
        public CashAddUI(int AccountId)
        {
            // İlgili account nesnesi
            InitializeComponent();
            Id = AccountId;
        }
        private void BtnBuy_Click(object sender, EventArgs e)
        {
            // Para onay varlık nesnesi girdileri 
            CashConfirmation cashConfirmatin = new CashConfirmation();
            cashConfirmatin.AccountId = Id;
            cashConfirmatin.PendingCash = Convert.ToInt32(TxCountOfProduct.Text);
            // Para onay varlık nesnesi yönetim nesnesi
            CashConfirmationManager cashConfirmation = new CashConfirmationManager(new EfCashConfirmationDal());
            cashConfirmation.Add(cashConfirmatin);
            // Para onay sistem mesajı.
            MessageBox.Show(cashConfirmatin.PendingCash +"TL lik işleminiz Sıraya alınmıştır.", "Gönderildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CashAddUI_Load(object sender, EventArgs e)
        {
             
        }
    }
}

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
    public partial class CashConfirmationUI : Form
    {
        CashConfirmationManager cashConfirmationManager = new CashConfirmationManager(new EfCashConfirmationDal());
        public CashConfirmationUI()
        {
            InitializeComponent(); 
        }

        private void CashConfirmationUI_Load(object sender, EventArgs e)
        {
            GetDataGWData(); // DataGridView data fonksiyonu
        }

        private void GetDataGWData()
        {
            // DataGridView Data çekme ve başlık set edilme bloğu
            DwCashConfirmation.DataSource = cashConfirmationManager.GetCashConfirmationOrderDetail().Data;
            DwCashConfirmation.Columns[0].HeaderText = "İşlem Id";
            DwCashConfirmation.Columns[1].HeaderText = "Kimlik Nu";
            DwCashConfirmation.Columns[2].HeaderText = "Ad";
            DwCashConfirmation.Columns[3].HeaderText = "Soyad";
            DwCashConfirmation.Columns[4].HeaderText = "Bekleyen Bakiye";
        }

        private void BtnConfirmation_Click(object sender, EventArgs e)
        {
            // Seçiili işlem için onay verme bloğu 
            int ConfirmId = Convert.ToInt32(DwCashConfirmation.SelectedCells[0].Value);
            CashConfirmation cashConfirmation = cashConfirmationManager.GetById(ConfirmId).Data;
            AccountFinanceManager accountFinanceManager = new AccountFinanceManager(new EfAccountFinanceDal());
            AccountFinance accountFinance = accountFinanceManager.GetByAccount(cashConfirmation.AccountId).Data;
            // Seçili işlem için girdi değerlerinin database İşlemi
            accountFinance.Id = cashConfirmation.AccountId;
            accountFinance.Cash += cashConfirmation.PendingCash;
            accountFinanceManager.Update(accountFinance);
            // Seçili işlem tamamlanır ve silinir.
            cashConfirmationManager.Delete(cashConfirmation);
            // DataGridView verileri güncellenir.
            GetDataGWData();
        }
    }
}

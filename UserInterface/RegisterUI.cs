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
    public partial class RegisterUI : Form
    {
        public RegisterUI()
        {
            InitializeComponent();
        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterSave(); // database Ekleme fonksiyonu
        }

        private void RegisterSave()
        {
            // Varlık sınıfları için oluşturulan nesneler
            Account account = new Account();
            AccountAsset accountAsset = new AccountAsset();
            AccountInformation accountInformation = new AccountInformation();
            AccountFinance accountFinance = new AccountFinance();
            // varlık sınıflarının yönetilmesi için oluşturulan nesneler
            AccountAssetManager accountAssetManager = new AccountAssetManager(new EfAccountAssetDal());
            AccountFinanceManager accountFinanceManager = new AccountFinanceManager(new EfAccountFinanceDal());
            AccountManager accountManager = new AccountManager(new EfAccountDal());
            AccountInformationManager accountInformationManager = new AccountInformationManager(new EfAccountInformationDal());
            // Account Bilgi girdileri
            account.AccountName = TbAccountName.Text;
            account.AccountType = 1;
            account.Password = TbPassword.Text;
            accountManager.Add(account);
            // Account varlıkları için oluşturulan hesap Girdileri
            accountInformation.Id = accountManager.Get(account).Data.Id;
            accountFinance.Id = accountInformation.Id;
            accountFinanceManager.Add(accountFinance);
            // Account kimlik bilgilerinin girdileri
            accountInformation.Name = TbName.Text;
            accountInformation.Surname = TbSurname.Text;
            accountInformation.Tc_No = tbTc.Text;
            accountInformation.TelNo = TbTelNo.Text;
            accountInformation.Adress = TbAdress.Text;
            accountInformation.Email = TbEmail.Text;
            accountInformationManager.Add(accountInformation);
            // kayıt olma işlemi sonrası mesaj.
            MessageBox.Show("Sayın " + accountInformation.Name + " " + accountInformation.Surname + " Üyeliğiniz Başarıyla oluşturulmuştur!", "Kaydınız Alındı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RegisterUI_Load(object sender, EventArgs e)
        {

        }
    }
}

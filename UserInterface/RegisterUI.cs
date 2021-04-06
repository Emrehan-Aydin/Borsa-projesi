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
            Account account = new Account();
            AccountInformation accountInformation = new AccountInformation();
            AccountManager accountManager = new AccountManager(new EfAccountDal());
            AccountInformationManager accountInformationManager = new AccountInformationManager(new EfAccountInformationDal());
            account.AccountName = TbAccountName.Text;
            account.AccountType = 1;
            account.Password = TbPassword.Text;
            accountManager.Add(account);
            accountInformation.Id = (int)accountManager.Get(account).Data.Id;
            accountInformation.Name = TbName.Text;
            accountInformation.Surname = TbSurname.Text;
            accountInformation.Tc_No = tbTc.Text;
            accountInformation.TelNo = TbTelNo.Text;
            accountInformation.Adress = TbAdress.Text;
            accountInformation.Email = TbEmail.Text;
            accountInformationManager.Add(accountInformation);
            MessageBox.Show("Sayın "+ accountInformation.Name+" "+accountInformation.Surname+" Üyeliğiniz Başarıyla oluşturulmuştur!");
        }
        private void RegisterUI_Load(object sender, EventArgs e)
        {

        }
    }
}

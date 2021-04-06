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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterUI registerUI = new RegisterUI();
            registerUI.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AccountManager accountManager = new AccountManager(new EfAccountDal());
            Account account = new Account();
            account.AccountName = tbAccountName.Text;
            account.Password = TbPassword.Text;
            if (accountManager.Get(account).Data==null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }
            else if(accountManager.Get(account).Data.AccountName==tbAccountName.Text && TbPassword.Text==accountManager.Get(account).Data.Password)
            {
                MessageBox.Show("Giriş Başarılı");
                UserIndexUI userIndexUI = new UserIndexUI();
                userIndexUI.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.ShowDialog();
        }
    }
}

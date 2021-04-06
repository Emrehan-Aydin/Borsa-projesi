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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AccountManager accountManager = new AccountManager(new EfAccountDal());
            Account account = new Account();
            account.AccountName = tbAccountName.Text;
            account.Password = TbPassword.Text;
            if (accountManager.Get(account).Data != null)
            {
                Account logaccount = accountManager.Get(account).Data;
                 if (logaccount.AccountName == tbAccountName.Text && TbPassword.Text == logaccount.Password && logaccount.AccountType==2)
                {
                    MessageBox.Show("Giriş Başarılı");
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                }
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı!");
            }
            
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

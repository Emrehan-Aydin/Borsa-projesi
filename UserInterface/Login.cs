using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using ShopBusiness;
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
            RegisterUI registerUI = new RegisterUI();  // Kayıt olma forum nesnesi 
            registerUI.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var result = checkPerson(1); // Permission değeri 1 olan kontrol 
            if (result.Success)
            {
                UserIndexUI userIndexUI = new UserIndexUI(result.Data); // UserIndex form nesnesi oluşturulur
                userIndexUI.ShowDialog(); // formu görüntüle.
            }
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            var result = checkPerson(2); // Permission değeri 2 olan kontrol 
            if (result.Success)
            {
                AdminIndexUI adminIndexUI = new AdminIndexUI(result.Data);
                adminIndexUI.ShowDialog(); // formu görüntüle.
            }
        }
        public IDataResult<Account> checkPerson(int permission)
        {
            // kullanıcı kontrolü için Manager nesnesi
            AccountManager accountManager = new AccountManager(new EfAccountDal());
            // Girilen kullanıcı bilgileri için oluşturulan nesne
            Account account = new Account
            {
                AccountName = tbAccountName.Text,
                Password = TbPassword.Text,
                AccountType = permission
            };
            // Böyle bir kullanıcı var mı ? kontrolünü true/false dönen metod 
            var result = accountManager.Get(account); 
            if (result.Data == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!","Başarısız giriş",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return result;
            }
            else
            {
                MessageBox.Show("Giriş Başarılı", "Başarılı giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return result;
            }
        }
    }
}

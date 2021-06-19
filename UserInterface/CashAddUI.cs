using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.TcmbService;
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
        TcmbManager tcmbManager = new TcmbManager();
        int Id;
        decimal pendingCash = 0;
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
            cashConfirmatin.PendingCash = pendingCash;
            // Para onay varlık nesnesi yönetim nesnesi
            CashConfirmationManager cashConfirmation = new CashConfirmationManager(new EfCashConfirmationDal());
            if (pendingCash != 0)
            {
                cashConfirmation.Add(cashConfirmatin);
                // Para onay sistem mesajı.
                MessageBox.Show(cashConfirmatin.PendingCash + "TL lik işleminiz Sıraya alınmıştır.", "Gönderildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen yüklenecek Para birim ve tutar değerinizi giriniz.");
            }
        }

        private void CashAddUI_Load(object sender, EventArgs e)
        {
            GetUnitCbData();
            Lb_CalculateMoney.Visible = false;
        }

        private void GetUnitCbData()
        {
            Cb_UnitMoney.Items.Clear();
            foreach (var Unit in tcmbManager.GetUnit())
            {
                Cb_UnitMoney.Items.Add(Unit);
            }
            Cb_UnitMoney.SelectedIndex = 12;
        }

        private void Cb_UnitMoney_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateMoney();
        }

        private void calculateMoney()
        {

            if (Tb_UnitMoney.TextLength != 0)
            {
                pendingCash = Convert.ToDecimal(Tb_UnitMoney.Text) * (tcmbManager.getUnitValue(Cb_UnitMoney.SelectedIndex));
                Lb_CalculateMoney.Text = Tb_UnitMoney.Text + " " + Cb_UnitMoney.SelectedItem.ToString() + " = " + Convert.ToDecimal(Tb_UnitMoney.Text) * (tcmbManager.getUnitValue(Cb_UnitMoney.SelectedIndex)) + " Türk Lirası";
            }
        }

        private void Tb_UnitMoney_TextChanged(object sender, EventArgs e)
        {

            Lb_CalculateMoney.Visible = true;
            calculateMoney();
        }
    }
}

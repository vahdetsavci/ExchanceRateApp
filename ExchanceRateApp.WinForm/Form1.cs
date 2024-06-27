using ExchanceRateApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchanceRateApp.WinForm
{
    public partial class Form1 : Form
    {
        ExchanceRateApp.Core.BusinessLogicLayer BLL;

        public Form1()
        {
            InitializeComponent();
            BLL = new Core.BusinessLogicLayer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetInfo();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            GetInfo();
        }

        void GetInfo()
        {
            BLL.UpdateExchangeRates();
            List<Currency> currencies = BLL.GetCurrencies();
            List<ExchangeRate> exchangeRateInfos = BLL.GetExchangeRates();

            ExchangeRate usd = exchangeRateInfos.FirstOrDefault(I => I.CurrencyID == currencies.FirstOrDefault(x => x.Code == "USD").ID);
            lbl_buying_usd.Text = usd.Buying.ToString();
            lbl_selling_usd.Text = usd.Selling.ToString();

            ExchangeRate eur = exchangeRateInfos.FirstOrDefault(I => I.CurrencyID == currencies.FirstOrDefault(x => x.Code == "EUR").ID);
            lbl_buying_eur.Text = eur.Buying.ToString();
            lbl_selling_eur.Text = eur.Selling.ToString();

            ExchangeRate gbp = exchangeRateInfos.FirstOrDefault(I => I.CurrencyID == currencies.FirstOrDefault(x => x.Code == "GBP").ID);
            lbl_buying_gbp.Text = gbp.Buying.ToString();
            lbl_selling_gbp.Text = gbp.Selling.ToString();

            lbl_exchange_rate_date.Text = gbp.Date.ToString();

            grd_exchange_rate_history.DataSource = BLL.ViewExchangeRateHistory();
            grd_exchange_rate_history.Columns[4].Width = 150;
            grd_exchange_rate_history.Sort(grd_exchange_rate_history.Columns[4], ListSortDirection.Descending);
        }
    }
}

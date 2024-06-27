using ExchanceRateApp.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ExchanceRateApp.Core
{
    public sealed class BusinessLogicLayer
    {
        DatabaseLogicLayer DLL;
        SqlDataReader reader;

        public BusinessLogicLayer()
        {
            DLL = new DatabaseLogicLayer();
        }

        public List<Currency> GetCurrencies()
        {
            List<Currency> currencies = new List<Currency>();
            reader = DLL.GetCurrencies();

            while (reader.Read())
            {
                currencies.Add(new Currency()
                {
                    ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                    Code = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    Definition = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    WarningLimit = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3)
                });
            }
            reader.Close();
            DLL.SetConnection();
            return currencies;
        }

        public void UpdateExchangeRates()
        {
            System.Net.WebClient webClient = new System.Net.WebClient();
            string JsonDatatxt = webClient.DownloadString("https://finans.truncgil.com/devextreme-datasource.php");
            List<JsonDataType> ExchangeRateInformation = Newtonsoft.Json.JsonConvert.DeserializeObject<List<JsonDataType>>(JsonDatatxt);

            List<Currency> currencies = GetCurrencies();
            for (int i = 0; i < currencies.Count; i++)
            {
                JsonDataType foundData = ExchangeRateInformation.FirstOrDefault(I => I.Currency == currencies[i].Code);
                AddExchangeRate(Guid.NewGuid(), currencies[i].ID, decimal.Parse(foundData.Buying), decimal.Parse(foundData.Selling), DateTime.Now);
            }
        }

        public DataTable ViewExchangeRateHistory()
        {
            DataTable DT = new DataTable();
            DT.Columns.Add("Döviz Tanımı", typeof(string));
            DT.Columns.Add("Döviz Kodu", typeof(string));
            DT.Columns.Add("Alış", typeof(string));
            DT.Columns.Add("Satış", typeof(string));
            DT.Columns.Add("Tarih", typeof(string));

            List<ExchangeRateHistory> exchangeRateHistoryList = GetExchangeRateHistory();
            List<Currency> currencyList = GetCurrencies();

            for (int i = 0; i < exchangeRateHistoryList.Count; i++)
            {
                DT.Rows.Add(
                    currencyList.FirstOrDefault(I => I.ID == exchangeRateHistoryList[i].CurrencyID).Definition,
                    currencyList.FirstOrDefault(I => I.ID == exchangeRateHistoryList[i].CurrencyID).Code,
                    exchangeRateHistoryList[i].Buying.ToString(),
                    exchangeRateHistoryList[i].Selling.ToString(),
                    exchangeRateHistoryList[i].Date.ToString("F")
                    );
            }

            return DT;
        }

        public List<ExchangeRate> GetExchangeRates()
        {
            List<ExchangeRate> exchangeRates = new List<ExchangeRate>();
            reader = DLL.GetExchangeRates();

            while (reader.Read())
            {
                exchangeRates.Add(new ExchangeRate()
                {
                    ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                    CurrencyID = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
                    Buying = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                    Selling = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                    Date = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4)
                });
            }
            reader.Close();
            DLL.SetConnection();
            return exchangeRates;
        }

        public ExchangeRate GetExchangeRate(Guid CurrencyID)
        {
            ExchangeRate exchangeRate = null;
            reader = DLL.GetExchangeRate(CurrencyID);

            if (reader.Read())
            {
                exchangeRate = new ExchangeRate()
                {
                    ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                    CurrencyID = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
                    Buying = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                    Selling = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                    Date = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4)
                };
            }
            reader.Close();
            DLL.SetConnection();
            return exchangeRate;
        }

        public List<ExchangeRateHistory> GetExchangeRateHistory()
        {
            List<ExchangeRateHistory> exchangeRateHistory = new List<ExchangeRateHistory>();
            reader = DLL.GetExchangeRateHistory();

            while (reader.Read())
            {
                exchangeRateHistory.Add(new ExchangeRateHistory()
                {
                    ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                    ExchangeRateID = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
                    CurrencyID = reader.IsDBNull(2) ? Guid.Empty : reader.GetGuid(2),
                    Buying = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                    Selling = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
                    Date = reader.IsDBNull(5) ? DateTime.MinValue : reader.GetDateTime(5),
                });
            }
            reader.Close();
            DLL.SetConnection();
            return exchangeRateHistory;
        }

        public List<ExchangeRateHistory> GetExchangeRateHistory(Guid CurrencyID)
        {
            List<ExchangeRateHistory> exchangeRateHistory = new List<ExchangeRateHistory>();
            reader = DLL.GetExchangeRateHistory(CurrencyID);

            while (reader.Read())
            {
                exchangeRateHistory.Add(new ExchangeRateHistory()
                {
                    ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                    ExchangeRateID = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
                    CurrencyID = reader.IsDBNull(2) ? Guid.Empty : reader.GetGuid(2),
                    Buying = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                    Selling = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
                    Date = reader.IsDBNull(5) ? DateTime.MinValue : reader.GetDateTime(5),
                });
            }
            reader.Close();
            DLL.SetConnection();
            return exchangeRateHistory;
        }

        public int AddExchangeRate(Guid ID, Guid CurrencyID, decimal Buying, decimal Selling, DateTime Date)
        {
            if (ID != Guid.Empty && CurrencyID != Guid.Empty && Buying != 0 && Selling != 0 && Date > DateTime.MinValue)
            {
                return DLL.AddExchangeRate(new ExchangeRate()
                {
                    ID = ID,
                    CurrencyID = CurrencyID,
                    Buying = Buying,
                    Selling = Selling,
                    Date = Date
                });
            }
            else
            {
                NLog.Logger logger = NLog.LogManager.GetLogger("fileLogger");
                logger.Error("Parameter conditions required to add exchange rate are not met!");
                return 0;
            }
        }
    }
}

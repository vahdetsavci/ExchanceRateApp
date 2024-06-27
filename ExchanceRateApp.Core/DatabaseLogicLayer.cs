using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchanceRateApp.Core
{
    public sealed class DatabaseLogicLayer
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;

        public DatabaseLogicLayer()
        {
            connection = new SqlConnection("data source=.; initial catalog=ExchangeRateDb; integrated security=true;");
        }

        public void SetConnection()
        {
            switch (connection.State)
            {
                case System.Data.ConnectionState.Open:
                    connection.Close();
                    break;
                default:
                    connection.Open();
                    break;
            }
        }

        public SqlDataReader GetCurrencies()
        {
            Helper.TryCatchNLog(() =>
            {
                command = new SqlCommand("GetCurrencies", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SetConnection();
                reader = command.ExecuteReader();
            });
            return reader;
        }

        public SqlDataReader GetExchangeRates()
        {
            Helper.TryCatchNLog(() =>
            {
                command = new SqlCommand("GetExchangeRates", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SetConnection();
                reader = command.ExecuteReader();
            });
            return reader;
        }

        public SqlDataReader GetExchangeRate(Guid CurrencyID)
        {
            Helper.TryCatchNLog(() =>
            {
                command = new SqlCommand("GetExchangeRateByCurrencyID", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@CurrencyID", System.Data.SqlDbType.UniqueIdentifier).Value = CurrencyID;
                SetConnection();
                reader = command.ExecuteReader();
            });
            return reader;
        }

        public SqlDataReader GetExchangeRateHistory()
        {
            Helper.TryCatchNLog(() =>
            {
                command = new SqlCommand("GetExchangeRateHistory", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SetConnection();
                reader = command.ExecuteReader();
            });
            return reader;
        }

        public SqlDataReader GetExchangeRateHistory(Guid CurrencyID)
        {
            Helper.TryCatchNLog(() =>
            {
                command = new SqlCommand("GetExchangeRateHistoryByCurrencyID", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@CurrencyID", System.Data.SqlDbType.UniqueIdentifier).Value = CurrencyID;
                SetConnection();
                reader = command.ExecuteReader();
            });
            return reader;
        }

        public int AddExchangeRate(Entities.ExchangeRate exchangeRate)
        {
            int result = 0;

            Helper.TryCatchNLog(() =>
            {
                command = new SqlCommand("InsertExchangeRate", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@ID", System.Data.SqlDbType.UniqueIdentifier).Value = exchangeRate.ID;
                command.Parameters.Add("@CurrencyID", System.Data.SqlDbType.UniqueIdentifier).Value = exchangeRate.CurrencyID;
                command.Parameters.Add("@Buying", System.Data.SqlDbType.Decimal).Value = exchangeRate.Buying;
                command.Parameters.Add("@Selling", System.Data.SqlDbType.Decimal).Value = exchangeRate.Selling;
                command.Parameters.Add("@Date", System.Data.SqlDbType.DateTime).Value = exchangeRate.Date;
                SetConnection();
                result = command.ExecuteNonQuery();
            });
            SetConnection();
            return result;
        }
    }
}

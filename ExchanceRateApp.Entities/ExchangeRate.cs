using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchanceRateApp.Entities
{
    public sealed class ExchangeRate
    {
        public Guid ID { get; set; }
        public Guid CurrencyID { get; set; }
        public decimal Buying { get; set; }
        public decimal Selling { get; set; }
        public DateTime Date { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchanceRateApp.Entities
{
    public sealed class Currency
    {
        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Definition { get; set; }
        public decimal WarningLimit { get; set; }
    }
}

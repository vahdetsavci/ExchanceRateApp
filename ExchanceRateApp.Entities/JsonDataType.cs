using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchanceRateApp.Entities
{
    public sealed class JsonDataType
    {
        public string Currency { get; set; }
        public string Buying { get; set; }
        public string Selling { get; set; }
        public string Change { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchanceRateApp.Core
{
    public static class Helper
    {
        public static void TryCatchNLog(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                NLog.Logger logger = NLog.LogManager.GetLogger("fileLogger");
                logger.Error(ex.Message);
            }
        }
    }
}

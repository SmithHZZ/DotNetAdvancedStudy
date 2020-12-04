using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace _24_asp.net_mvc5.Utility
{
    public class LogHelper
    {
        private LogHelper()
        {

        }

        public static readonly log4net.ILog InfoLogger = log4net.LogManager.GetLogger("InfoLogger");

        public static readonly log4net.ILog ErrorLogger = log4net.LogManager.GetLogger("ErrorLogger");

        public static void SetConfig()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        public static void SetConfig(FileInfo configFile)
        {
            log4net.Config.XmlConfigurator.Configure(configFile);
        }

        public static void WriteLog(string info)
        {
            if (InfoLogger.IsInfoEnabled)
            {
                InfoLogger.Info(info);
            }
        }

        public static void WriteLog(string info, Exception se)
        {
            if (ErrorLogger.IsErrorEnabled)
            {
                ErrorLogger.Error(info, se);
            }
        }
    }
}
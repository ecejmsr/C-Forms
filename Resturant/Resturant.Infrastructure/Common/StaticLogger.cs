using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Resturant.Infrastructure.Common
{
    class StaticLogger
    {
        public static void LogInfo(Type declartingType, string text)
        {
            LogManager.GetLogger(declartingType.FullName).Info(text);
        }

        public static void LogWarn(Type declartingType, string text)
        {
            LogManager.GetLogger(declartingType.FullName).Warn(text);
        }

        public static void LogDebug(Type declartingType, string text)
        {
            LogManager.GetLogger(declartingType.FullName).Debug(text);
        }

        public static void LogTrace(Type declartingType, string text)
        {
            LogManager.GetLogger(declartingType.FullName).Trace(text);
        }

        public static void LogError(Type declartingType, string text)
        {
            LogManager.GetLogger(declartingType.FullName).Error(text);
        }

        public static void LogFatal(Type declartingType, string text)
        {
            LogManager.GetLogger(declartingType.FullName).Fatal(text);
        }
    }
}

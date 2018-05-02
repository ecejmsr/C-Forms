using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Resturant.Infrastructure.Common
{
    public class ApplicationBase
    {
        protected Logger Log { get; private set; }

        protected ApplicationBase(Type declaringType)
        {
            Log = LogManager.GetLogger(declaringType.FullName);
        }

        protected void LogDebug(string s)
        {
            Log.Debug(s);
        }

        protected void LogInfo(string s)
        {
            Log.Info(s);
        }

        protected void LogTrace(string s)
        {
            Log.Trace(s);
        }

        protected void LogWarn(string s)
        {
            Log.Warn(s);
        }

        protected void LogError(string s)
        {
            Log.Error(s);
        }

        protected void LogFatal(string s)
        {
            Log.Fatal(s);
        }
    }
}

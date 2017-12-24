using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Logging
{
    public enum Level
    {
        Error,
        Warning,
        Information,
        SuccessAudit,
        FailureAudit
    }

    public interface ILogger
    {
        void Log(Level level,string msg);
        void Log(Level level, string msg, System.Exception exception);

    }

    public abstract class LogManager : IDisposable
    {
        #region Singleton Property
        // Singleton
        private static LogManager _current;

        public static LogManager Current
        {
            get
            {
                // Require
                if (_current == null) throw new InvalidOperationException();

                // Return
                return _current;
            }
            set
            {
                // Require
                if (_current != null) throw new InvalidOperationException();

                // Return
                _current = value;
            }
        }
        #endregion

        #region Methods
        // Methods
        public abstract ILogger CreateLogger(string name);

        public abstract void Dispose();
        #endregion
    }

}

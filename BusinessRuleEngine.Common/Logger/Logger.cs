using System;

using BusinessRuleEngine.Enums;

namespace BusinessRuleEngine.Common.Logger
{
    ///<summary>
    /// Represents logger class. It is made as singletone.
    ///</summary>
    public sealed class Logger
    {
        private static readonly Lazy<Logger> log = new Lazy<Logger>(() => new Logger());
        private static Logger instance = null;

        private Logger()
        {
        }

        ///<summary>
        /// Gets the logger instance.
        ///</summary>	
        public static Logger Instance
        {
            get
            {
                if (instance == null) 
                { 
                    instance = log.Value; 
                }

                return instance;
            }
        }

        ///<summary>
        /// Logs the error or information.
        ///</summary>
        public void Log(LoggerType loggerType, string message)
        {
            // Codes to be written for log.
        }
    }
}

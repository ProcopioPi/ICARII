using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MasterHound
{
    public class Logger
    {
        private static Logger instance;
        private static StringBuilder sb = new StringBuilder();

        public static Logger Instance
        {
            get {
                if (instance == null)
                    instance = new Logger();

                return Logger.instance; 
            }
            set { Logger.instance = value; }
        }

        public void Log(string message)
        {
            message = message.Replace(K.SPACE, K.TAB + K.TAB + K.TAB + K.TAB + K.TAB);
            sb.Append(message);
            File.AppendAllText(K.LOG_FILE, sb.ToString());
            sb.Clear();
        }
    }
}

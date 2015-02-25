using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsService1
{
   public static class LogEvent
    {
       public static void WriteErrorLog(string errorMessage)
       {
           using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "LogFile.txt", true))
           {
               sw.WriteLine(DateTime.Now.ToString() + ":" + errorMessage.ToString());
               sw.Flush();
           }
       }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{
    public sealed class Logging
    {
        private static Logging instance=null;
        private Logging()
        {

        }
        public static Logging Instance
        {
           get
           {
             if (instance == null)
             {
                    instance = new Logging();
             }
                return instance;
           }
              
        }
        public void AddLoggingDetails(string msg)
        {
            string pathString = @"C:\LoggingDetails.txt";

            using (StreamWriter sw = File.AppendText(pathString))
            {
                sw.WriteLine(msg);
                
            }
        }
    }
}

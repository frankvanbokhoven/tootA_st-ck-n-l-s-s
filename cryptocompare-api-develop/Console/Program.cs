using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Timers;
using System.Reflection;

namespace tootAConsole
{
    class Program
    {
        private static getData gd = new getData();
        static void Main(string[] args)
        {
            //   getData gd = new getData();

            Timer timerhart = new System.Timers.Timer(3000);
            Console.Write(string.Format("tootA 2018 - Messages Builddate: {0}", utils.GetLinkerDateTime(Assembly.GetExecutingAssembly(), null)));
            Console.Write(Environment.NewLine);
            timerhart.Enabled = false;
            timerhart.Elapsed += Timerhart_Elapsed;
            timerhart.Enabled = true;

            Console.ReadLine();
            timerhart.Enabled = false;

        }

        private static void Timerhart_Elapsed(object sender, ElapsedEventArgs e)
        {
            //  getData getData = new getData();
            gd.GetAndReportStatus();

        }
    }


}


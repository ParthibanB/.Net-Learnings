using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace WindowsService1
{
    public partial class Scheduler : ServiceBase
    {
        private Timer _timer;
        public Scheduler()
        {
            this.ServiceName = "DemeServiceParthi";
            InitializeComponent();   
        }

        protected override void OnStart(string[] args)
        {
            _timer = new Timer();
            _timer.Interval = 10000;
            _timer.Elapsed +=new ElapsedEventHandler(OnElapsedTime);
            _timer.Enabled = true;    
        }

        private void OnElapsedTime(object sender, ElapsedEventArgs e)
        {
            LogEvent.WriteErrorLog("Scheduler Windows Service Started");
        }
              

        protected override void OnStop()
        {
            LogEvent.WriteErrorLog("Scheduler Windows Service Stoped");
        }
    }
}

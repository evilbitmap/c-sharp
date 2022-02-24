using System;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace Conneciton_status_WPF_
{
    class GetPing
    {
        public static int PingLatency{ get; set; }

        static BackgroundWorker BackgroundWorkerPing = new BackgroundWorker();
        public void SetWorkerPing()
        {
            BackgroundWorkerPing.DoWork += new DoWorkEventHandler(backgroundWorkerPing_DoWork);
            BackgroundWorkerPing.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorkerPing_Done);
            BackgroundWorkerPing.RunWorkerAsync();

        }

        private void backgroundWorkerPing_DoWork(object sender, DoWorkEventArgs e)
        {
            Ping ping = new Ping();
            try
            {
                PingReply reply = ping.Send(Properties.Settings.Default.PingHost, 1000);
                if (reply != null)
                {
                    PingLatency = Convert.ToInt32(reply.RoundtripTime);
                }
                else
                {
                    PingLatency = Convert.ToInt32(reply.RoundtripTime);
                }
            }
            catch (Exception)
            {
                PingLatency = 0;
            }
        }
        private void backgroundWorkerPing_Done(object sender, RunWorkerCompletedEventArgs e)
        {
            BackgroundWorkerPing.RunWorkerAsync();
        }
    }
}
using System;
using System.Net.NetworkInformation;

namespace Conneciton_status_WPF_
{
    class GetPing
    {
        public static int Ping()
        {
            ValueClass data = new ValueClass();
            Ping ping = new Ping();
            try
            {
                PingReply reply = ping.Send(data.PingHost, 1000);
                if (reply != null)
                {
                    return Convert.ToInt32(reply.RoundtripTime);
                }
                else
                {
                    return Convert.ToInt32(reply.RoundtripTime);
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}

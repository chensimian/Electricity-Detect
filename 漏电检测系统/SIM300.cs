using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 漏电检测系统
{
    public class SIM300
    {
        public string Content { get; set; }
        public Thread thread;
        SIM300Param SIM300Param = new SIM300Param();
        public EventHandler<_NotifyMessageEventArgs> NotifyUi;
        public UdpClient _udpClient { get; set; }
        public SIM300(int port)
        {
            _udpClient = new UdpClient(port);
        }
        public void Connect(string ip, string port)
        {
            _udpClient.Connect(IPAddress.Parse(ip), Convert.ToInt32(port));
            thread = new Thread(ReceiveData);
            thread.Start();
        }
        public void TimeIs()
        {
            string Time = "#0" + DateTime.Now.ToString("yyyyMMddHHmmss") + "17*";
            _udpClient.Client.Send(Encoding.Default.GetBytes(Time));
        }

        public void Close()
        {
            _udpClient.Client.Close();
        }
        private void ReceiveData()
        {
            while (_udpClient.Client.Connected)
            {
                try
                {
                    byte[] data = new byte[1024];
                    int length = _udpClient.Client.Receive(data);
                    byte[] dataRec = new byte[length];
                    Array.Copy(data, dataRec, length);
                    Content = Encoding.Default.GetString(dataRec);
                    if(Content.Length==41)
                    {
                        SIM300Param.Index++;
                        SIM300Param.Imea = Content.Substring(2, 15);
                        SIM300Param.Line = Content.Substring(17, 2);
                        SIM300Param.Dangwei = Content.Substring(19, 1);
                        SIM300Param.Adc = Convert.ToInt64(Content.Substring(20, 4)) * 3.3 / (double)4096;
                        SIM300Param.Datetime = Content.Substring(24, 14);
                        OnNotify(new _NotifyMessageEventArgs(SIM300Param));
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
        }
        protected void OnNotify(_NotifyMessageEventArgs args)
        {
            if (NotifyUi != null)
            {
                NotifyUi(this, args);
            }
        }
    }
}

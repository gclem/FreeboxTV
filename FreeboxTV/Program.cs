using Constellation;
using Constellation.Package;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace FreeboxTV
{
    public class Program : PackageBase
    {
        static void Main(string[] args)
        {
            PackageHost.Start<Program>(args);
            //PackageHost.Start<Demo>(args);
        }

        public override void OnStart()
        {
            PackageHost.WriteInfo("Package starting - IsRunning: {0} - IsConnected: {1}", PackageHost.IsRunning, PackageHost.IsConnected);
        }

        [MessageCallback]
        /// <summary>
        /// Send power command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendPower(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=power&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send home command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendHome(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=home&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send mute command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendMute(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=mute&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send back command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendBack(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=back&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send volume increase command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendVolumeUp(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=vol_inc&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send volume decrease command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendVolumeDown(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=vol_dec&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send channel up command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendChannelUp(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=prgm_inc&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send channel down command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendChannelDown(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=prgm_dec&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send ok command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendOk(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=ok&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send up command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendUp(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=up&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send down command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendDown(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=down&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send left command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendLeft(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=left&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send right command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendRight(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=right&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send backward command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendBackward(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=bwd&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send forward command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendForward(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=fwd&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send previous command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendPrevious(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=prev&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send next command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendNext(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=next&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send play command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendPlay(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=play&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send red command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendRed(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=red&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send blue command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendBlue(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=blue&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send green command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendGreen(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=Green&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send yellow command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendYellow(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=yellow&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send channel list command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendList(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=list&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

        [MessageCallback]
        /// <summary>
        /// Send TV command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendTV(bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=tv&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
            PackageHost.WriteInfo(strReq);
        }

    }
}

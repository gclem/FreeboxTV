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
        }

        public override void OnStart()
        {
            PackageHost.WriteInfo("Package starting - IsRunning: {0} - IsConnected: {1}", PackageHost.IsRunning, PackageHost.IsConnected);
        }

        public void SendCommand(string Command, bool Type)
        {
            string RemoteKey = PackageHost.GetSettingValue<string>("RemoteKey");
            WebClient instanceHTTP = new WebClient();
            string strReq = "";
            strReq = "http://hd1.freebox.fr/pub/remote_control?code=" + RemoteKey + "&key=" + Command + "&long=" + Type;
            Uri MyURI = new Uri(strReq);
            string retval = instanceHTTP.DownloadString(MyURI);
        }

        [MessageCallback]
        /// <summary>
        /// Send power command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendPower(bool Type)
        {
            SendCommand("power", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send home command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendHome(bool Type)
        {
            SendCommand("home", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send mute command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendMute(bool Type)
        {
            SendCommand("mute", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send back command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendBack(bool Type)
        {
            SendCommand("back", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send volume increase command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendVolumeUp(bool Type)
        {
            SendCommand("vol_inc", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send volume decrease command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendVolumeDown(bool Type)
        {
            SendCommand("vol_dec", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send channel up command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendChannelUp(bool Type)
        {
            SendCommand("prgm_inc", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send channel down command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendChannelDown(bool Type)
        {
            SendCommand("prgm_dec", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send ok command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendOk(bool Type)
        {
            SendCommand("ok", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send up command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendUp(bool Type)
        {
            SendCommand("up", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send down command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendDown(bool Type)
        {
            SendCommand("down", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send left command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendLeft(bool Type)
        {
            SendCommand("left", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send right command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendRight(bool Type)
        {
            SendCommand("right", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send backward command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendBackward(bool Type)
        {
            SendCommand("bwd", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send forward command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendForward(bool Type)
        {
            SendCommand("fwd", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send previous command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendPrevious(bool Type)
        {
            SendCommand("prev", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send next command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendNext(bool Type)
        {
            SendCommand("next", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send play command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendPlay(bool Type)
        {
            SendCommand("play", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send red command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendRed(bool Type)
        {
            SendCommand("red", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send blue command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendBlue(bool Type)
        {
            SendCommand("blue", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send green command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendGreen(bool Type)
        {
            SendCommand("green", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send yellow command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendYellow(bool Type)
        {
            SendCommand("yellow", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send channel list command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendList(bool Type)
        {
            SendCommand("list", Type);
        }

        [MessageCallback]
        /// <summary>
        /// Send TV command
        /// </summary>
        /// <param name="Type">if set to <c>true</c> emulate long press.</param>
        public void SendTV(bool Type)
        {
            SendCommand("tv", Type);
        }

    }
}

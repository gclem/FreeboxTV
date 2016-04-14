namespace FreeboxTV.Remote
{
    using FreeboxTV.Remote.Enumerations;
    using FreeboxTV.Remote.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HttpFreeRemoteController : IRemoteController<FreeCommandKey, FreeCommandType>
    {
        public HttpFreeRemoteController()
        {

        }


        public void SendKey(FreeCommandKey command, FreeCommandType commandType)
        {
            throw new NotImplementedException();
        }
    }
}

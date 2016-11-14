using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using pj;

namespace cli_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var ep = new Endpoint();
            ep.libCreate();
            var ep_cfg = new EpConfig();
            ep.libInit(ep_cfg);

            var trans_cfg = new TransportConfig();
            ep.transportCreate(pjsip_transport_type_e.PJSIP_TRANSPORT_UDP, trans_cfg);

            ep.libStart();

            var acc_cfg = new AccountConfig();
            acc_cfg.idUri = "sip:1005@192.168.20.249";
            acc_cfg.regConfig.registrarUri = "sip:192.168.20.249";
            acc_cfg.sipConfig.authCreds.Add(new AuthCredInfo("digest", "*", "1005", 0, "123456"));

            var acc = new Account();
            acc.create(acc_cfg);

            while (true)
            {
                var s = Console.ReadLine(); 
                if (s.Trim().ToUpper().StartsWith("Q"))
                {
                    break;
                }
            }

            ep.libDestroy();
        }
    }
}

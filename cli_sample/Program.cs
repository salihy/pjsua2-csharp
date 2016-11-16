using System;
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
            ep_cfg.uaConfig.userAgent = String.Format(
                "pjsip-{0} {1}-{2}.{3} dotNET-{4}",
                Endpoint.instance().libVersion().full,
                Environment.OSVersion.Platform.ToString(),
                Environment.OSVersion.Version.Major,
                Environment.OSVersion.Version.Minor,
                Environment.Version.ToString()
            );
            ep.libInit(ep_cfg);

            var trans_cfg = new TransportConfig();
            ep.transportCreate(pjsip_transport_type_e.PJSIP_TRANSPORT_UDP, trans_cfg);

            ep.libStart();

            var acc_cfg = new AccountConfig();
            acc_cfg.idUri = "sip:1005@192.168.20.249";
            acc_cfg.regConfig.registrarUri = "sip:192.168.20.249";
            acc_cfg.sipConfig.authCreds.Add(new AuthCredInfo("digest", "*", "1005", 0, "123456"));

            var acc = new MyAccount();
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

        class MyAccount : Account
        {
            public override void onRegState(OnRegStateParam prm)
            {
                if (this.getInfo().regIsActive)
                {
                    Console.WriteLine(String.Format("\n\n Registered: {0} {1} \n\n", (uint)prm.code, prm.reason));
                }
                else
                {
                    Console.WriteLine(String.Format("\n\n Unregistered: {0} {1} \n\n", (uint)prm.code, prm.reason));
                }
            }
        }
    }
}

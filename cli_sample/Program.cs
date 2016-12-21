using System;
using pj;

namespace cli_sample
{
    class Program
    {
        static internal Endpoint ep = new Endpoint();
        static MyAccount localAcc = new MyAccount();
        static AccountConfig localAccCfg = new AccountConfig();
        static EpConfig epCfg = new EpConfig();
        static void Main(string[] args)
        {
            ep.libCreate();
            //if (!ep.libIsThreadRegistered())
            //    ep.libRegisterThread("main");
            epCfg.uaConfig.userAgent = String.Format(
                "pjsip-{0} {1}-{2}.{3} dotNET-{4}",
                Endpoint.instance().libVersion().full,
                Environment.OSVersion.Platform.ToString(),
                Environment.OSVersion.Version.Major,
                Environment.OSVersion.Version.Minor,
                Environment.Version.ToString()
            );
            ep.libInit(epCfg);
            ep.libStart();

            var trans_cfg = new TransportConfig();
            trans_cfg.port = 5062;
            ep.transportCreate(pjsip_transport_type_e.PJSIP_TRANSPORT_UDP, trans_cfg);

            localAccCfg.idUri = string.Format("sip:0.0.0.0:{0}", trans_cfg.port);
            Console.WriteLine(string.Format("timerMinSESec={0} timerSessExpiresSec={1}", localAccCfg.callConfig.timerMinSESec, localAccCfg.callConfig.timerSessExpiresSec));
            localAccCfg.callConfig.timerMinSESec = 90;
            localAccCfg.callConfig.timerSessExpiresSec = 1800;

            //var user_name = "liuxy";
            //var registrant_host = "sip.dev.yunhuni.com";
            //var password = "123456";
            //localAccCfg.idUri = string.Format("sip:{0}@{1}", user_name, registrant_host);
            //localAccCfg.regConfig.registrarUri = string.Format("sip:{0}", registrant_host);
            //localAccCfg.sipConfig.authCreds.Add(new AuthCredInfo("digest", "*", user_name, 0, password));
            localAcc.create(localAccCfg);


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

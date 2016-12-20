using System;
using pj;

namespace cli_sample
{
    class Program
    {
        static Endpoint ep = new Endpoint();
        static MyAccount localAcc = new MyAccount();

        static void Main(string[] args)
        {
            ep.libCreate();
            try
            {

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
                trans_cfg.port = 5060;
                ep.transportCreate(pjsip_transport_type_e.PJSIP_TRANSPORT_UDP, trans_cfg);
                ep.libStart();

                var acc_cfg = new AccountConfig();
                acc_cfg.idUri = string.Format("sip:0.0.0.0:{0}", trans_cfg.port);
                localAcc.create(acc_cfg);

                while (true)
                {
                    var s = Console.ReadLine();
                    if (s.Trim().ToUpper().StartsWith("Q"))
                    {
                        break;
                    }
                }
            }
            catch (RumtimeException e)
            {
                Console.WriteLine(String.Format("PJSIP 错误： {0}: {1}", e.status, e.reason));
            }
            finally
            {
                ep.libDestroy();
            }
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

            public override void onIncomingCall(OnIncomingCallParam prm)
            {
                base.onIncomingCall(prm);
                var call = new MyCall(this, prm.callId);
                var callOpParam = new CallOpParam();
                callOpParam.statusCode = pjsip_status_code.PJSIP_SC_OK;
                call.answer(callOpParam);
            }
        }
    }
}

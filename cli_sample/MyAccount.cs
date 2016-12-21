using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pj;

namespace cli_sample
{
    class MyAccount : Account
    {
        public override void onRegState(OnRegStateParam prm)
        {
            base.onRegState(prm);
        }

        public override void onIncomingCall(OnIncomingCallParam prm)
        {
            base.onIncomingCall(prm);
            Console.WriteLine("事件：入方向呼叫");
            var call = new MyCall(this, prm.callId);
            var callOpParam = new CallOpParam();
            callOpParam.statusCode = pjsip_status_code.PJSIP_SC_RINGING; // pjsip_status_code.PJSIP_SC_OK;
            call.answer(callOpParam);
        }
    }
}

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
            var call = new MyCall(this, prm.callId);
            var callOpParam = new CallOpParam();
            callOpParam.statusCode = pjsip_status_code.PJSIP_SC_OK;
            call.answer(callOpParam);
        }
    }
}

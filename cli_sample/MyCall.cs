using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using pj;

namespace cli_sample
{
    class MyCall : Call
    {
        public MyCall(Account acc, int call_id) : base(acc, call_id) { }

        public MyCall(Account acc) : base(acc) { }

        public override void onCallState(OnCallStateParam prm)
        {
            base.onCallState(prm);
            var ci = this.getInfo();
            if (ci.state == pjsip_inv_state.PJSIP_INV_STATE_DISCONNECTED)
            {
                Dispose();
            }
        }

        public override void onCallMediaState(OnCallMediaStateParam prm)
        {
            base.onCallMediaState(prm);
            var ci = getInfo();
            for (uint i = 0; i < ci.media.Count; i++)
            {
                if (ci.media[(int)i].type == pjmedia_type.PJMEDIA_TYPE_AUDIO)
                {

                    var audMed = AudioMedia.typecastFromMedia(this.getMedia(i));
                    var mgr = Endpoint.instance().audDevManager();
                    audMed.startTransmit(mgr.getPlaybackDevMedia());
                    mgr.getCaptureDevMedia().startTransmit(audMed);
                }
                else
                {
                    throw new ApplicationException("现在仅支持音频哦亲");
                }
            }
        }
    }
}

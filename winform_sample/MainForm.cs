using System;
using System.Windows.Forms;

using pj;

namespace winform_sample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Endpoint ep;
        MyAccount localAcc;

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ep.libDestroy();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ep = new Endpoint();
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
            trans_cfg.port = 5062;
            ep.transportCreate(pjsip_transport_type_e.PJSIP_TRANSPORT_UDP, trans_cfg);

            ep.libStart();

            var acc_cfg = new AccountConfig();
            acc_cfg.idUri = "sip:0.0.0.0:5062";
            localAcc = new MyAccount();
            localAcc.create(acc_cfg);
        }
    }
}

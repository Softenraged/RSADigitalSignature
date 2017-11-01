using RSASignature.Auth.Participants;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RSASignature.Model
{
    public partial class ClientForm : Form
    {

        private ServerForm server;
        private Client client = null;

        public ClientForm(ServerForm server)
        {
            this.server = server;
            InitializeComponent();
        }

        public async Task Initialize()
        {

            client = await Client.Create();
            server.AcceptKey(client.PassPublicKey());

            InitControlElements();
        }

        private async void SendRequest(object sender, EventArgs e)
        {
            Request.Enabled = false;

            client.Message = Message.Text;

            var result = await client.Send();

            if ( await server.Verify(result) )
            {

            }

            Request.Enabled = true;
       
        }


        private void InitControlElements()
        {
            Generation.Visible = false;
            MsgLabel.Visible = true;
            Message.Show();
            Request.Show();
        }
    }
}

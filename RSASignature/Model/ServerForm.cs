using RSASignature.Auth.Participants;
using RSASignature.Auth.Sign;
using RSASignature.KeyGeneration.Keys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSASignature.Model
{
    public partial class ServerForm : Form
    {

        private Server server = new Server();

        public ServerForm()
        {
            InitializeComponent();
        }

        public void AcceptKey(PublicKey key)
        {
            server.AcceptKey(key);
        }

        public async Task<bool> Verify(Signature signature)
        {
            var result = await server.Verify(signature);

            Log.AppendText($"{DateTime.Now}: Попытка авторизации - " + (result ? "успех.\r\n" : "неудача.\r\n") );

            return result; 
        }
    }
}

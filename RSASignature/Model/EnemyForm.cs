using RSASignature.Auth.Participants;
using System;
using System.Windows.Forms;

namespace RSASignature.Model
{
    public partial class EnemyForm : Form
    {
        private ServerForm server;
        private Enemy enemy = new Enemy();

        public EnemyForm(ServerForm server)
        {
            InitializeComponent();
            InitControlElements();
            this.server = server;
        }


        private async void Attack(object sender, EventArgs e)
        {

            AttackBtn.Enabled = false;

            enemy.CatchMessage(Message.Text);

            var result = await enemy.Attack();

            if (await server.Verify(result))
            {

            }

            AttackBtn.Enabled = true;
        }


        private void InitControlElements()
        {
            Generation.Visible = false;
            MsgLabel.Visible = true;
            Message.Show();
            AttackBtn.Show();
        }
    }
}

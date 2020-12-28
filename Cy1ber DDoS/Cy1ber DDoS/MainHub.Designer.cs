
namespace Cy1ber_DDoS
{
    partial class MainHub
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.host1 = new MetroFramework.Controls.MetroTextBox();
            this.port1 = new MetroFramework.Controls.MetroTextBox();
            this.time1 = new MetroFramework.Controls.MetroTextBox();
            this.method1 = new MetroFramework.Controls.MetroComboBox();
            this.send = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // host1
            // 
            this.host1.Location = new System.Drawing.Point(109, 76);
            this.host1.Name = "host1";
            this.host1.Size = new System.Drawing.Size(163, 23);
            this.host1.TabIndex = 0;
            this.host1.Text = "Host";
            this.host1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.host1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // port1
            // 
            this.port1.Location = new System.Drawing.Point(109, 124);
            this.port1.Name = "port1";
            this.port1.Size = new System.Drawing.Size(163, 23);
            this.port1.TabIndex = 1;
            this.port1.Text = "Port";
            this.port1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // time1
            // 
            this.time1.Location = new System.Drawing.Point(109, 168);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(163, 23);
            this.time1.Style = MetroFramework.MetroColorStyle.Blue;
            this.time1.TabIndex = 2;
            this.time1.Text = "Time";
            this.time1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // method1
            // 
            this.method1.FormattingEnabled = true;
            this.method1.ItemHeight = 23;
            this.method1.Items.AddRange(new object[] {
            "ChargenLz",
            "RandFlood",
            "NtpFlood xTs3",
            "GreenSyn",
            "Hping3",
            "cfreeze",
            "xDNS"});
            this.method1.Location = new System.Drawing.Point(109, 217);
            this.method1.Name = "method1";
            this.method1.Size = new System.Drawing.Size(163, 29);
            this.method1.TabIndex = 3;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(109, 267);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(163, 31);
            this.send.TabIndex = 4;
            this.send.Text = "Send Attack";
            this.send.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // MainHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.send);
            this.Controls.Add(this.method1);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.port1);
            this.Controls.Add(this.host1);
            this.Name = "MainHub";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainHub_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox host1;
        private MetroFramework.Controls.MetroTextBox port1;
        private MetroFramework.Controls.MetroTextBox time1;
        private MetroFramework.Controls.MetroComboBox method1;
        private MetroFramework.Controls.MetroButton send;
    }
}
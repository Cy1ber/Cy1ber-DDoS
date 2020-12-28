
namespace Cy1ber_DDoS
{
    partial class Login
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
            this.Username = new MetroFramework.Controls.MetroTextBox();
            this.Password = new MetroFramework.Controls.MetroTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(91, 63);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(198, 23);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            this.Username.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Username.Click += new System.EventHandler(this.username1_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(91, 124);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '●';
            this.Password.Size = new System.Drawing.Size(198, 23);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            this.Password.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Password.UseSystemPasswordChar = true;
            this.Password.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 53);
            this.button2.TabIndex = 0;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.button2);
            this.Name = "Login";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox Username;
        private MetroFramework.Controls.MetroTextBox Password;
        private System.Windows.Forms.Button button2;
    }
}


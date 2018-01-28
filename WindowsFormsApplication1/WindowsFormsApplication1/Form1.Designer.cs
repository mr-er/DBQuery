namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.tBoxHostname = new System.Windows.Forms.TextBox();
            this.tBoxUsername = new System.Windows.Forms.TextBox();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.rTBConsole = new System.Windows.Forms.RichTextBox();
            this.bReadSQLFile = new System.Windows.Forms.Button();
            this.bDBConnection = new System.Windows.Forms.Button();
            this.tBoxConnectionPort = new System.Windows.Forms.TextBox();
            this.lServer = new System.Windows.Forms.Label();
            this.lPort = new System.Windows.Forms.Label();
            this.lUser = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.rTBQuery = new System.Windows.Forms.RichTextBox();
            this.bDoQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxHostname
            // 
            this.tBoxHostname.Location = new System.Drawing.Point(107, 20);
            this.tBoxHostname.Name = "tBoxHostname";
            this.tBoxHostname.Size = new System.Drawing.Size(154, 20);
            this.tBoxHostname.TabIndex = 0;
            // 
            // tBoxUsername
            // 
            this.tBoxUsername.Location = new System.Drawing.Point(107, 72);
            this.tBoxUsername.Name = "tBoxUsername";
            this.tBoxUsername.Size = new System.Drawing.Size(154, 20);
            this.tBoxUsername.TabIndex = 1;
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.Location = new System.Drawing.Point(107, 98);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.PasswordChar = '*';
            this.tBoxPassword.Size = new System.Drawing.Size(154, 20);
            this.tBoxPassword.TabIndex = 2;
            // 
            // rTBConsole
            // 
            this.rTBConsole.Location = new System.Drawing.Point(267, 124);
            this.rTBConsole.Name = "rTBConsole";
            this.rTBConsole.ReadOnly = true;
            this.rTBConsole.Size = new System.Drawing.Size(532, 81);
            this.rTBConsole.TabIndex = 3;
            this.rTBConsole.Text = "";
            // 
            // bReadSQLFile
            // 
            this.bReadSQLFile.Location = new System.Drawing.Point(107, 124);
            this.bReadSQLFile.Name = "bReadSQLFile";
            this.bReadSQLFile.Size = new System.Drawing.Size(154, 23);
            this.bReadSQLFile.TabIndex = 4;
            this.bReadSQLFile.Text = "Wczytaj plik SQL";
            this.bReadSQLFile.UseVisualStyleBackColor = true;
            this.bReadSQLFile.Click += new System.EventHandler(this.bReadSQLFile_Click);
            // 
            // bDBConnection
            // 
            this.bDBConnection.Location = new System.Drawing.Point(107, 153);
            this.bDBConnection.Name = "bDBConnection";
            this.bDBConnection.Size = new System.Drawing.Size(154, 23);
            this.bDBConnection.TabIndex = 6;
            this.bDBConnection.Text = "Połącz z bazą";
            this.bDBConnection.UseVisualStyleBackColor = true;
            this.bDBConnection.Click += new System.EventHandler(this.bDBConnection_Click);
            // 
            // tBoxConnectionPort
            // 
            this.tBoxConnectionPort.Location = new System.Drawing.Point(107, 46);
            this.tBoxConnectionPort.Name = "tBoxConnectionPort";
            this.tBoxConnectionPort.Size = new System.Drawing.Size(154, 20);
            this.tBoxConnectionPort.TabIndex = 9;
            this.tBoxConnectionPort.Text = "5432";
            // 
            // lServer
            // 
            this.lServer.AutoSize = true;
            this.lServer.Location = new System.Drawing.Point(27, 23);
            this.lServer.Name = "lServer";
            this.lServer.Size = new System.Drawing.Size(41, 13);
            this.lServer.TabIndex = 10;
            this.lServer.Text = "Server:";
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(27, 46);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(29, 13);
            this.lPort.TabIndex = 11;
            this.lPort.Text = "Port:";
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Location = new System.Drawing.Point(27, 75);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(65, 13);
            this.lUser.TabIndex = 12;
            this.lUser.Text = "Użytkownik:";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(29, 101);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(39, 13);
            this.lPassword.TabIndex = 13;
            this.lPassword.Text = "Hasło:";
            // 
            // rTBQuery
            // 
            this.rTBQuery.Location = new System.Drawing.Point(267, 20);
            this.rTBQuery.Name = "rTBQuery";
            this.rTBQuery.Size = new System.Drawing.Size(532, 98);
            this.rTBQuery.TabIndex = 14;
            this.rTBQuery.Text = "";
            // 
            // bDoQuery
            // 
            this.bDoQuery.Location = new System.Drawing.Point(107, 182);
            this.bDoQuery.Name = "bDoQuery";
            this.bDoQuery.Size = new System.Drawing.Size(154, 23);
            this.bDoQuery.TabIndex = 15;
            this.bDoQuery.Text = "Wykonaj zapytanie";
            this.bDoQuery.UseVisualStyleBackColor = true;
            this.bDoQuery.Click += new System.EventHandler(this.bDoQuery_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 225);
            this.Controls.Add(this.bDoQuery);
            this.Controls.Add(this.rTBQuery);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lUser);
            this.Controls.Add(this.lPort);
            this.Controls.Add(this.lServer);
            this.Controls.Add(this.tBoxConnectionPort);
            this.Controls.Add(this.bDBConnection);
            this.Controls.Add(this.bReadSQLFile);
            this.Controls.Add(this.rTBConsole);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.tBoxUsername);
            this.Controls.Add(this.tBoxHostname);
            this.Name = "Form1";
            this.Text = "DB Query";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxHostname;
        private System.Windows.Forms.TextBox tBoxUsername;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.RichTextBox rTBConsole;
        private System.Windows.Forms.Button bReadSQLFile;
        private System.Windows.Forms.Button bDBConnection;
        private System.Windows.Forms.TextBox tBoxConnectionPort;
        private System.Windows.Forms.Label lServer;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.RichTextBox rTBQuery;
        private System.Windows.Forms.Button bDoQuery;
    }
}


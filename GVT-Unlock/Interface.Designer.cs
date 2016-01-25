namespace GVT_Unlock
{
    partial class Interface
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxRetroceder = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBoxIP = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIpGerencia = new System.Windows.Forms.TextBox();
            this.textBoxIpModem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDesbRemoto = new System.Windows.Forms.Button();
            this.btnDesbLocal = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblServerStatus);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBoxRetroceder);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.checkBoxIP);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxIpGerencia);
            this.panel1.Controls.Add(this.textBoxIpModem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDesbRemoto);
            this.panel1.Controls.Add(this.btnDesbLocal);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 124);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "00:00";
            this.label1.Visible = false;
            // 
            // checkBoxRetroceder
            // 
            this.checkBoxRetroceder.Location = new System.Drawing.Point(16, 73);
            this.checkBoxRetroceder.Name = "checkBoxRetroceder";
            this.checkBoxRetroceder.Size = new System.Drawing.Size(268, 21);
            this.checkBoxRetroceder.TabIndex = 0;
            this.checkBoxRetroceder.Text = "Retroceder desboqueio (runLevel(2))";
            this.checkBoxRetroceder.UseVisualStyleBackColor = true;
            this.checkBoxRetroceder.CheckedChanged += new System.EventHandler(this.checkBoxRetroceder_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(1210, 96);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(124, 17);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Recuperar IP local";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkBoxIP
            // 
            this.checkBoxIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxIP.AutoSize = true;
            this.checkBoxIP.Location = new System.Drawing.Point(1127, 14);
            this.checkBoxIP.Name = "checkBoxIP";
            this.checkBoxIP.Size = new System.Drawing.Size(207, 21);
            this.checkBoxIP.TabIndex = 26;
            this.checkBoxIP.Text = "Editar informações de setup";
            this.checkBoxIP.UseVisualStyleBackColor = true;
            this.checkBoxIP.CheckedChanged += new System.EventHandler(this.checkBoxIP_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1094, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "IP Gerência";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1106, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "IP Modem";
            // 
            // textBoxIpGerencia
            // 
            this.textBoxIpGerencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIpGerencia.Location = new System.Drawing.Point(1182, 70);
            this.textBoxIpGerencia.Name = "textBoxIpGerencia";
            this.textBoxIpGerencia.Size = new System.Drawing.Size(152, 22);
            this.textBoxIpGerencia.TabIndex = 23;
            this.textBoxIpGerencia.TextChanged += new System.EventHandler(this.textBoxIpGerencia_TextChanged);
            // 
            // textBoxIpModem
            // 
            this.textBoxIpModem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIpModem.Location = new System.Drawing.Point(1182, 40);
            this.textBoxIpModem.Name = "textBoxIpModem";
            this.textBoxIpModem.Size = new System.Drawing.Size(152, 22);
            this.textBoxIpModem.TabIndex = 22;
            this.textBoxIpModem.TextChanged += new System.EventHandler(this.textBoxIpModem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "OU";
            // 
            // btnDesbRemoto
            // 
            this.btnDesbRemoto.Enabled = false;
            this.btnDesbRemoto.Location = new System.Drawing.Point(308, 59);
            this.btnDesbRemoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesbRemoto.Name = "btnDesbRemoto";
            this.btnDesbRemoto.Size = new System.Drawing.Size(181, 28);
            this.btnDesbRemoto.TabIndex = 16;
            this.btnDesbRemoto.Text = "2. Iniciar processo remoto";
            this.btnDesbRemoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesbRemoto.UseVisualStyleBackColor = true;
            this.btnDesbRemoto.Click += new System.EventHandler(this.btnDesbRemoto_Click);
            // 
            // btnDesbLocal
            // 
            this.btnDesbLocal.Enabled = false;
            this.btnDesbLocal.Location = new System.Drawing.Point(308, 10);
            this.btnDesbLocal.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesbLocal.Name = "btnDesbLocal";
            this.btnDesbLocal.Size = new System.Drawing.Size(181, 28);
            this.btnDesbLocal.TabIndex = 15;
            this.btnDesbLocal.Text = "2. Iniciar processo local";
            this.btnDesbLocal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesbLocal.UseVisualStyleBackColor = true;
            this.btnDesbLocal.Click += new System.EventHandler(this.btnDesbLocal_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(16, 35);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(225, 28);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "1. Efetuar login no modem";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(760, 40);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(153, 28);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 96);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(298, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Habilitar SSH (Somente desbloqueio local)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1007, 449);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "*** O desbloqueio poderá afetar o serviço de TV!";
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.AutoSize = true;
            this.lblServerStatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerStatus.Location = new System.Drawing.Point(619, 97);
            this.lblServerStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(96, 17);
            this.lblServerStatus.TabIndex = 20;
            this.lblServerStatus.Text = "Verificando";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Status servidor remoto: ";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 263);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1356, 212);
            this.textBox1.TabIndex = 6;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 124);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(1356, 139);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 475);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GVT Pace v5471 Unlock - v0.6";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDesbRemoto;
        private System.Windows.Forms.Button btnDesbLocal;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblServerStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIpGerencia;
        private System.Windows.Forms.TextBox textBoxIpModem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxIP;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBoxRetroceder;
    }
}


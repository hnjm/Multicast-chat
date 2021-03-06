﻿namespace MulticastChat
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.buttonJoin = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.listBoxMessageChat = new System.Windows.Forms.ListBox();
            this.labelNewMessage = new System.Windows.Forms.Label();
            this.textBoxNewMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.checkBoxUseEncryption = new System.Windows.Forms.CheckBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(12, 13);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(80, 16);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "User Name:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(104, 10);
            this.textBoxUserName.MaxLength = 16;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(173, 22);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBoxUserName_TextChanged);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(24, 35);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(62, 16);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(94, 30);
            this.textBoxAddress.MaxLength = 15;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(135, 22);
            this.textBoxAddress.TabIndex = 2;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(24, 74);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(35, 16);
            this.labelPort.TabIndex = 4;
            this.labelPort.Text = "Port:";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(94, 71);
            this.textBoxPort.MaxLength = 5;
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(53, 22);
            this.textBoxPort.TabIndex = 3;
            this.textBoxPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPort_KeyPress);
            // 
            // buttonJoin
            // 
            this.buttonJoin.Location = new System.Drawing.Point(12, 234);
            this.buttonJoin.Name = "buttonJoin";
            this.buttonJoin.Size = new System.Drawing.Size(79, 37);
            this.buttonJoin.TabIndex = 6;
            this.buttonJoin.Text = "Join Chat";
            this.buttonJoin.UseVisualStyleBackColor = true;
            this.buttonJoin.Click += new System.EventHandler(this.buttonJoin_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Enabled = false;
            this.buttonExit.Location = new System.Drawing.Point(234, 231);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(79, 40);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit Chat";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // listBoxMessageChat
            // 
            this.listBoxMessageChat.Enabled = false;
            this.listBoxMessageChat.FormattingEnabled = true;
            this.listBoxMessageChat.ItemHeight = 16;
            this.listBoxMessageChat.Location = new System.Drawing.Point(15, 21);
            this.listBoxMessageChat.Name = "listBoxMessageChat";
            this.listBoxMessageChat.Size = new System.Drawing.Size(376, 180);
            this.listBoxMessageChat.TabIndex = 8;
            // 
            // labelNewMessage
            // 
            this.labelNewMessage.AutoSize = true;
            this.labelNewMessage.Location = new System.Drawing.Point(19, 206);
            this.labelNewMessage.Name = "labelNewMessage";
            this.labelNewMessage.Size = new System.Drawing.Size(98, 16);
            this.labelNewMessage.TabIndex = 10;
            this.labelNewMessage.Text = "New message:";
            // 
            // textBoxNewMessage
            // 
            this.textBoxNewMessage.Enabled = false;
            this.textBoxNewMessage.Location = new System.Drawing.Point(22, 225);
            this.textBoxNewMessage.MaxLength = 150;
            this.textBoxNewMessage.Name = "textBoxNewMessage";
            this.textBoxNewMessage.Size = new System.Drawing.Size(306, 22);
            this.textBoxNewMessage.TabIndex = 9;
            this.textBoxNewMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewMessage_KeyPress);
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(334, 224);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(57, 23);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // checkBoxUseEncryption
            // 
            this.checkBoxUseEncryption.AutoSize = true;
            this.checkBoxUseEncryption.Location = new System.Drawing.Point(164, 74);
            this.checkBoxUseEncryption.Name = "checkBoxUseEncryption";
            this.checkBoxUseEncryption.Size = new System.Drawing.Size(125, 21);
            this.checkBoxUseEncryption.TabIndex = 4;
            this.checkBoxUseEncryption.Text = "Use Encryption";
            this.checkBoxUseEncryption.UseVisualStyleBackColor = true;
            this.checkBoxUseEncryption.CheckedChanged += new System.EventHandler(this.checkBoxUseEncryption_CheckedChanged);
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(25, 112);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(34, 16);
            this.labelKey.TabIndex = 14;
            this.labelKey.Text = "Key:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelKey);
            this.groupBox1.Controls.Add(this.labelAddress);
            this.groupBox1.Controls.Add(this.textBoxKey);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.checkBoxUseEncryption);
            this.groupBox1.Controls.Add(this.labelPort);
            this.groupBox1.Controls.Add(this.textBoxPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 152);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chat configurations";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Enabled = false;
            this.textBoxKey.HideSelection = false;
            this.textBoxKey.Location = new System.Drawing.Point(95, 112);
            this.textBoxKey.MaxLength = 16;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(170, 22);
            this.textBoxKey.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSend);
            this.groupBox2.Controls.Add(this.textBoxNewMessage);
            this.groupBox2.Controls.Add(this.labelNewMessage);
            this.groupBox2.Controls.Add(this.listBoxMessageChat);
            this.groupBox2.Location = new System.Drawing.Point(332, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 261);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message Chat";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 280);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonJoin);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Multicast Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonJoin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelNewMessage;
        private System.Windows.Forms.TextBox textBoxNewMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ListBox listBoxMessageChat;
        private System.Windows.Forms.CheckBox checkBoxUseEncryption;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxKey;
    }
}



namespace JeuRonron
{
    partial class DiscordForm
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
            this.btImportConv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboChannels = new System.Windows.Forms.ComboBox();
            this.btDetectGuild = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboGuilds = new System.Windows.Forms.ComboBox();
            this.btAddBot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btImportConv
            // 
            this.btImportConv.Enabled = false;
            this.btImportConv.Location = new System.Drawing.Point(438, 149);
            this.btImportConv.Name = "btImportConv";
            this.btImportConv.Size = new System.Drawing.Size(152, 23);
            this.btImportConv.TabIndex = 13;
            this.btImportConv.Text = "Importer la conversation";
            this.btImportConv.UseVisualStyleBackColor = true;
            this.btImportConv.Click += new System.EventHandler(this.btImportConv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Channel :";
            // 
            // comboChannels
            // 
            this.comboChannels.FormattingEnabled = true;
            this.comboChannels.Location = new System.Drawing.Point(146, 151);
            this.comboChannels.Name = "comboChannels";
            this.comboChannels.Size = new System.Drawing.Size(260, 21);
            this.comboChannels.TabIndex = 11;
            // 
            // btDetectGuild
            // 
            this.btDetectGuild.Location = new System.Drawing.Point(438, 106);
            this.btDetectGuild.Name = "btDetectGuild";
            this.btDetectGuild.Size = new System.Drawing.Size(152, 23);
            this.btDetectGuild.TabIndex = 10;
            this.btDetectGuild.Text = "Detect";
            this.btDetectGuild.UseVisualStyleBackColor = true;
            this.btDetectGuild.Click += new System.EventHandler(this.btDetectGuild_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Serveur :";
            // 
            // comboGuilds
            // 
            this.comboGuilds.FormattingEnabled = true;
            this.comboGuilds.Location = new System.Drawing.Point(146, 110);
            this.comboGuilds.Name = "comboGuilds";
            this.comboGuilds.Size = new System.Drawing.Size(260, 21);
            this.comboGuilds.TabIndex = 8;
            this.comboGuilds.SelectedIndexChanged += new System.EventHandler(this.comboGuilds_SelectedIndexChanged);
            // 
            // btAddBot
            // 
            this.btAddBot.Location = new System.Drawing.Point(172, 34);
            this.btAddBot.Name = "btAddBot";
            this.btAddBot.Size = new System.Drawing.Size(234, 34);
            this.btAddBot.TabIndex = 7;
            this.btAddBot.Text = "Utiliser Discord";
            this.btAddBot.UseVisualStyleBackColor = true;
            this.btAddBot.Click += new System.EventHandler(this.btAddBot_Click);
            // 
            // DiscordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 274);
            this.Controls.Add(this.btImportConv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboChannels);
            this.Controls.Add(this.btDetectGuild);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboGuilds);
            this.Controls.Add(this.btAddBot);
            this.Name = "DiscordForm";
            this.Text = "DiscordForm";
            this.Load += new System.EventHandler(this.DiscordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btImportConv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboChannels;
        private System.Windows.Forms.Button btDetectGuild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboGuilds;
        private System.Windows.Forms.Button btAddBot;
    }
}
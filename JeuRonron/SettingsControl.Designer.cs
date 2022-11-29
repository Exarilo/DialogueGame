namespace JeuRonron
{
    partial class SettingsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDiscord = new System.Windows.Forms.Button();
            this.panelDiscord = new System.Windows.Forms.Panel();
            this.btImportConv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboChannels = new System.Windows.Forms.ComboBox();
            this.btDetectGuild = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboGuilds = new System.Windows.Forms.ComboBox();
            this.btAddBot = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btAudio = new System.Windows.Forms.Button();
            this.btReturn = new System.Windows.Forms.Button();
            this.panelAudio = new System.Windows.Forms.Panel();
            this.btVolB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackVolB = new System.Windows.Forms.TrackBar();
            this.btVolG = new System.Windows.Forms.Button();
            this.trackVolG = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            this.panelDiscord.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btDiscord);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 69);
            this.panel1.TabIndex = 1;
            // 
            // btDiscord
            // 
            this.btDiscord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDiscord.Location = new System.Drawing.Point(0, 0);
            this.btDiscord.Name = "btDiscord";
            this.btDiscord.Size = new System.Drawing.Size(902, 69);
            this.btDiscord.TabIndex = 4;
            this.btDiscord.Text = "DISCORD";
            this.btDiscord.UseVisualStyleBackColor = true;
            this.btDiscord.Click += new System.EventHandler(this.btDiscord_Click);
            // 
            // panelDiscord
            // 
            this.panelDiscord.Controls.Add(this.btImportConv);
            this.panelDiscord.Controls.Add(this.label2);
            this.panelDiscord.Controls.Add(this.comboChannels);
            this.panelDiscord.Controls.Add(this.btDetectGuild);
            this.panelDiscord.Controls.Add(this.label1);
            this.panelDiscord.Controls.Add(this.comboGuilds);
            this.panelDiscord.Controls.Add(this.btAddBot);
            this.panelDiscord.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDiscord.Location = new System.Drawing.Point(0, 69);
            this.panelDiscord.Name = "panelDiscord";
            this.panelDiscord.Size = new System.Drawing.Size(902, 100);
            this.panelDiscord.TabIndex = 3;
            this.panelDiscord.Visible = false;
            // 
            // btImportConv
            // 
            this.btImportConv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btImportConv.Enabled = false;
            this.btImportConv.Location = new System.Drawing.Point(459, 61);
            this.btImportConv.Name = "btImportConv";
            this.btImportConv.Size = new System.Drawing.Size(129, 23);
            this.btImportConv.TabIndex = 41;
            this.btImportConv.Text = "Importer la conversation";
            this.btImportConv.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Channel :";
            // 
            // comboChannels
            // 
            this.comboChannels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboChannels.FormattingEnabled = true;
            this.comboChannels.Location = new System.Drawing.Point(222, 61);
            this.comboChannels.Name = "comboChannels";
            this.comboChannels.Size = new System.Drawing.Size(200, 21);
            this.comboChannels.TabIndex = 39;
            this.comboChannels.SelectedIndexChanged += new System.EventHandler(this.comboChannels_SelectedIndexChanged);
            // 
            // btDetectGuild
            // 
            this.btDetectGuild.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btDetectGuild.Location = new System.Drawing.Point(459, 20);
            this.btDetectGuild.Name = "btDetectGuild";
            this.btDetectGuild.Size = new System.Drawing.Size(129, 23);
            this.btDetectGuild.TabIndex = 38;
            this.btDetectGuild.Text = "Detect";
            this.btDetectGuild.UseVisualStyleBackColor = true;
            this.btDetectGuild.Click += new System.EventHandler(this.btDetectGuild_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Serveur :";
            // 
            // comboGuilds
            // 
            this.comboGuilds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboGuilds.FormattingEnabled = true;
            this.comboGuilds.Location = new System.Drawing.Point(222, 20);
            this.comboGuilds.Name = "comboGuilds";
            this.comboGuilds.Size = new System.Drawing.Size(200, 21);
            this.comboGuilds.TabIndex = 36;
            // 
            // btAddBot
            // 
            this.btAddBot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btAddBot.BackgroundImage = global::JeuRonron.Properties.Resources.discord;
            this.btAddBot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAddBot.Location = new System.Drawing.Point(0, 0);
            this.btAddBot.Name = "btAddBot";
            this.btAddBot.Size = new System.Drawing.Size(108, 100);
            this.btAddBot.TabIndex = 35;
            this.btAddBot.UseVisualStyleBackColor = true;
            this.btAddBot.Click += new System.EventHandler(this.btAddBot_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btAudio);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(902, 69);
            this.panel3.TabIndex = 4;
            // 
            // btAudio
            // 
            this.btAudio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAudio.Location = new System.Drawing.Point(0, 0);
            this.btAudio.Name = "btAudio";
            this.btAudio.Size = new System.Drawing.Size(902, 69);
            this.btAudio.TabIndex = 0;
            this.btAudio.Text = "Audio";
            this.btAudio.UseVisualStyleBackColor = true;
            this.btAudio.Click += new System.EventHandler(this.btAudio_Click);
            // 
            // btReturn
            // 
            this.btReturn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btReturn.Location = new System.Drawing.Point(0, 538);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(902, 23);
            this.btReturn.TabIndex = 5;
            this.btReturn.Text = "------------->";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // panelAudio
            // 
            this.panelAudio.Controls.Add(this.btVolB);
            this.panelAudio.Controls.Add(this.label4);
            this.panelAudio.Controls.Add(this.label3);
            this.panelAudio.Controls.Add(this.trackVolB);
            this.panelAudio.Controls.Add(this.btVolG);
            this.panelAudio.Controls.Add(this.trackVolG);
            this.panelAudio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAudio.Location = new System.Drawing.Point(0, 238);
            this.panelAudio.Name = "panelAudio";
            this.panelAudio.Size = new System.Drawing.Size(902, 139);
            this.panelAudio.TabIndex = 6;
            this.panelAudio.Visible = false;
            // 
            // btVolB
            // 
            this.btVolB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btVolB.BackColor = System.Drawing.Color.Transparent;
            this.btVolB.BackgroundImage = global::JeuRonron.Properties.Resources.vol2;
            this.btVolB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btVolB.Location = new System.Drawing.Point(119, 86);
            this.btVolB.Name = "btVolB";
            this.btVolB.Size = new System.Drawing.Size(40, 33);
            this.btVolB.TabIndex = 43;
            this.btVolB.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Bruitage :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Son général :";
            // 
            // trackVolB
            // 
            this.trackVolB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trackVolB.Location = new System.Drawing.Point(165, 91);
            this.trackVolB.Maximum = 100;
            this.trackVolB.Name = "trackVolB";
            this.trackVolB.Size = new System.Drawing.Size(423, 45);
            this.trackVolB.TabIndex = 2;
            this.trackVolB.Value = 50;
            // 
            // btVolG
            // 
            this.btVolG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btVolG.BackColor = System.Drawing.Color.Transparent;
            this.btVolG.BackgroundImage = global::JeuRonron.Properties.Resources.vol2;
            this.btVolG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btVolG.Location = new System.Drawing.Point(119, 23);
            this.btVolG.Name = "btVolG";
            this.btVolG.Size = new System.Drawing.Size(40, 33);
            this.btVolG.TabIndex = 1;
            this.btVolG.UseVisualStyleBackColor = false;
            this.btVolG.Click += new System.EventHandler(this.btVolG_Click);
            // 
            // trackVolG
            // 
            this.trackVolG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trackVolG.Location = new System.Drawing.Point(165, 28);
            this.trackVolG.Maximum = 100;
            this.trackVolG.Name = "trackVolG";
            this.trackVolG.Size = new System.Drawing.Size(423, 45);
            this.trackVolG.TabIndex = 0;
            this.trackVolG.Value = 50;
            this.trackVolG.ValueChanged += new System.EventHandler(this.trackVolG_ValueChanged);
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelAudio);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelDiscord);
            this.Controls.Add(this.panel1);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(902, 561);
            this.Load += new System.EventHandler(this.SettingsControl_Load);
            this.panel1.ResumeLayout(false);
            this.panelDiscord.ResumeLayout(false);
            this.panelDiscord.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelAudio.ResumeLayout(false);
            this.panelAudio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btDiscord;
        private System.Windows.Forms.Panel panelDiscord;
        private System.Windows.Forms.Button btImportConv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboChannels;
        private System.Windows.Forms.Button btDetectGuild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboGuilds;
        private System.Windows.Forms.Button btAddBot;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btAudio;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Panel panelAudio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackVolB;
        private System.Windows.Forms.Button btVolG;
        private System.Windows.Forms.TrackBar trackVolG;
        private System.Windows.Forms.Button btVolB;
    }
}

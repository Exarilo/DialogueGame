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
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btImportConv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboChannels = new System.Windows.Forms.ComboBox();
            this.btDetectGuild = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.DiscordPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboGuilds = new System.Windows.Forms.ComboBox();
            this.btAddBot = new System.Windows.Forms.Button();
            this.AudioPage = new System.Windows.Forms.TabPage();
            this.labVolB = new System.Windows.Forms.Label();
            this.labVolG = new System.Windows.Forms.Label();
            this.btVolB = new System.Windows.Forms.Button();
            this.btVolG = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackVolB = new System.Windows.Forms.TrackBar();
            this.trackVolG = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.DiscordPage.SuspendLayout();
            this.AudioPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolG)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(776, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 489);
            this.button1.TabIndex = 59;
            this.button1.Text = "---> ---> --->";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(335, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "Los conversations";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(339, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "El botto discordo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackgroundImage = global::JeuRonron.Properties.Resources.flecheInvert;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(499, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = global::JeuRonron.Properties.Resources.fleche;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(203, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(0, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(808, 2);
            this.label5.TabIndex = 51;
            // 
            // btImportConv
            // 
            this.btImportConv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btImportConv.Enabled = false;
            this.btImportConv.Location = new System.Drawing.Point(508, 272);
            this.btImportConv.Name = "btImportConv";
            this.btImportConv.Size = new System.Drawing.Size(129, 21);
            this.btImportConv.TabIndex = 47;
            this.btImportConv.Text = "Importer la conversation";
            this.btImportConv.UseVisualStyleBackColor = true;
            this.btImportConv.Click += new System.EventHandler(this.btImportConv_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Channel :";
            // 
            // comboChannels
            // 
            this.comboChannels.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboChannels.FormattingEnabled = true;
            this.comboChannels.Location = new System.Drawing.Point(271, 272);
            this.comboChannels.Name = "comboChannels";
            this.comboChannels.Size = new System.Drawing.Size(200, 21);
            this.comboChannels.TabIndex = 45;
            // 
            // btDetectGuild
            // 
            this.btDetectGuild.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btDetectGuild.Location = new System.Drawing.Point(508, 231);
            this.btDetectGuild.Name = "btDetectGuild";
            this.btDetectGuild.Size = new System.Drawing.Size(129, 21);
            this.btDetectGuild.TabIndex = 44;
            this.btDetectGuild.Text = "Detect";
            this.btDetectGuild.UseVisualStyleBackColor = true;
            this.btDetectGuild.Click += new System.EventHandler(this.btDetectGuild_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.DiscordPage);
            this.tabSettings.Controls.Add(this.AudioPage);
            this.tabSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSettings.ItemSize = new System.Drawing.Size(58, 30);
            this.tabSettings.Location = new System.Drawing.Point(0, 0);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(816, 489);
            this.tabSettings.TabIndex = 58;
            // 
            // DiscordPage
            // 
            this.DiscordPage.Controls.Add(this.label7);
            this.DiscordPage.Controls.Add(this.label6);
            this.DiscordPage.Controls.Add(this.pictureBox2);
            this.DiscordPage.Controls.Add(this.pictureBox1);
            this.DiscordPage.Controls.Add(this.label5);
            this.DiscordPage.Controls.Add(this.btImportConv);
            this.DiscordPage.Controls.Add(this.label2);
            this.DiscordPage.Controls.Add(this.comboChannels);
            this.DiscordPage.Controls.Add(this.btDetectGuild);
            this.DiscordPage.Controls.Add(this.label1);
            this.DiscordPage.Controls.Add(this.comboGuilds);
            this.DiscordPage.Controls.Add(this.btAddBot);
            this.DiscordPage.Location = new System.Drawing.Point(4, 34);
            this.DiscordPage.Name = "DiscordPage";
            this.DiscordPage.Padding = new System.Windows.Forms.Padding(3);
            this.DiscordPage.Size = new System.Drawing.Size(808, 451);
            this.DiscordPage.TabIndex = 0;
            this.DiscordPage.Text = "Discord";
            this.DiscordPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Serveur :";
            // 
            // comboGuilds
            // 
            this.comboGuilds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboGuilds.FormattingEnabled = true;
            this.comboGuilds.Location = new System.Drawing.Point(271, 231);
            this.comboGuilds.Name = "comboGuilds";
            this.comboGuilds.Size = new System.Drawing.Size(200, 21);
            this.comboGuilds.TabIndex = 42;
            this.comboGuilds.SelectedIndexChanged += new System.EventHandler(this.comboChannels_SelectedIndexChanged);
            // 
            // btAddBot
            // 
            this.btAddBot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAddBot.BackgroundImage = global::JeuRonron.Properties.Resources.discord;
            this.btAddBot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAddBot.Location = new System.Drawing.Point(359, 54);
            this.btAddBot.Name = "btAddBot";
            this.btAddBot.Size = new System.Drawing.Size(86, 84);
            this.btAddBot.TabIndex = 36;
            this.btAddBot.UseVisualStyleBackColor = true;
            this.btAddBot.Click += new System.EventHandler(this.btAddBot_Click);
            // 
            // AudioPage
            // 
            this.AudioPage.Controls.Add(this.labVolB);
            this.AudioPage.Controls.Add(this.labVolG);
            this.AudioPage.Controls.Add(this.btVolB);
            this.AudioPage.Controls.Add(this.btVolG);
            this.AudioPage.Controls.Add(this.label8);
            this.AudioPage.Controls.Add(this.label4);
            this.AudioPage.Controls.Add(this.label3);
            this.AudioPage.Controls.Add(this.trackVolB);
            this.AudioPage.Controls.Add(this.trackVolG);
            this.AudioPage.Location = new System.Drawing.Point(4, 34);
            this.AudioPage.Name = "AudioPage";
            this.AudioPage.Padding = new System.Windows.Forms.Padding(3);
            this.AudioPage.Size = new System.Drawing.Size(808, 451);
            this.AudioPage.TabIndex = 1;
            this.AudioPage.Text = "Audio";
            this.AudioPage.UseVisualStyleBackColor = true;
            // 
            // labVolB
            // 
            this.labVolB.AutoSize = true;
            this.labVolB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labVolB.Location = new System.Drawing.Point(225, 173);
            this.labVolB.Name = "labVolB";
            this.labVolB.Size = new System.Drawing.Size(21, 13);
            this.labVolB.TabIndex = 60;
            this.labVolB.Text = "50";
            // 
            // labVolG
            // 
            this.labVolG.AutoSize = true;
            this.labVolG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labVolG.Location = new System.Drawing.Point(225, 113);
            this.labVolG.Name = "labVolG";
            this.labVolG.Size = new System.Drawing.Size(21, 13);
            this.labVolG.TabIndex = 59;
            this.labVolG.Text = "50";
            // 
            // btVolB
            // 
            this.btVolB.BackColor = System.Drawing.Color.Transparent;
            this.btVolB.BackgroundImage = global::JeuRonron.Properties.Resources.vol2;
            this.btVolB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btVolB.Location = new System.Drawing.Point(179, 160);
            this.btVolB.Name = "btVolB";
            this.btVolB.Size = new System.Drawing.Size(40, 38);
            this.btVolB.TabIndex = 57;
            this.btVolB.UseVisualStyleBackColor = false;
            this.btVolB.Click += new System.EventHandler(this.btVolB_Click);
            // 
            // btVolG
            // 
            this.btVolG.BackColor = System.Drawing.Color.Transparent;
            this.btVolG.BackgroundImage = global::JeuRonron.Properties.Resources.vol2;
            this.btVolG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btVolG.Location = new System.Drawing.Point(179, 100);
            this.btVolG.Name = "btVolG";
            this.btVolG.Size = new System.Drawing.Size(40, 38);
            this.btVolG.TabIndex = 56;
            this.btVolG.UseVisualStyleBackColor = false;
            this.btVolG.Click += new System.EventHandler(this.btVolG_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(333, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "La sonoridad";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Bruitage :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Son général :";
            // 
            // trackVolB
            // 
            this.trackVolB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackVolB.Location = new System.Drawing.Point(263, 160);
            this.trackVolB.Maximum = 100;
            this.trackVolB.Name = "trackVolB";
            this.trackVolB.Size = new System.Drawing.Size(423, 45);
            this.trackVolB.TabIndex = 46;
            this.trackVolB.Value = 50;
            this.trackVolB.ValueChanged += new System.EventHandler(this.trackVolB_ValueChanged);
            // 
            // trackVolG
            // 
            this.trackVolG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackVolG.Location = new System.Drawing.Point(263, 100);
            this.trackVolG.Maximum = 100;
            this.trackVolG.Name = "trackVolG";
            this.trackVolG.Size = new System.Drawing.Size(423, 45);
            this.trackVolG.TabIndex = 44;
            this.trackVolG.Value = 50;
            this.trackVolG.ValueChanged += new System.EventHandler(this.trackVolG_ValueChanged);
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabSettings);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(816, 489);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.DiscordPage.ResumeLayout(false);
            this.DiscordPage.PerformLayout();
            this.AudioPage.ResumeLayout(false);
            this.AudioPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btImportConv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboChannels;
        private System.Windows.Forms.Button btDetectGuild;
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage DiscordPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboGuilds;
        private System.Windows.Forms.Button btAddBot;
        private System.Windows.Forms.TabPage AudioPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackVolB;
        private System.Windows.Forms.TrackBar trackVolG;
        private System.Windows.Forms.Button btVolB;
        private System.Windows.Forms.Button btVolG;
        private System.Windows.Forms.Label labVolB;
        private System.Windows.Forms.Label labVolG;
    }
}

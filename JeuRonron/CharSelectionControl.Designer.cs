
namespace JeuRonron
{
    partial class CharSelectionControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSelect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panelChar = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btSettings = new System.Windows.Forms.PictureBox();
            this.buttonNext = new JeuRonron.RoundButton();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonPrevious = new JeuRonron.RoundButton();
            this.panel1.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btSettings)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSelect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 47);
            this.panel1.TabIndex = 0;
            // 
            // btSelect
            // 
            this.btSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSelect.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelect.Location = new System.Drawing.Point(0, 0);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(816, 47);
            this.btSelect.TabIndex = 9;
            this.btSelect.Text = "SELECT";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.MouseLeave += new System.EventHandler(this.btSelect_MouseLeave);
            this.btSelect.MouseHover += new System.EventHandler(this.btSelect_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.panelChar);
            this.panelBackground.Controls.Add(this.panelRight);
            this.panelBackground.Controls.Add(this.panelLeft);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(816, 442);
            this.panelBackground.TabIndex = 4;
            // 
            // panelChar
            // 
            this.panelChar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChar.Location = new System.Drawing.Point(82, 116);
            this.panelChar.Name = "panelChar";
            this.panelChar.Size = new System.Drawing.Size(652, 326);
            this.panelChar.TabIndex = 4;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.btSettings);
            this.panelRight.Controls.Add(this.buttonNext);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(734, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(82, 442);
            this.panelRight.TabIndex = 3;
            // 
            // btSettings
            // 
            this.btSettings.BackgroundImage = global::JeuRonron.Properties.Resources.settings;
            this.btSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSettings.Location = new System.Drawing.Point(33, 3);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(46, 40);
            this.btSettings.TabIndex = 2;
            this.btSettings.TabStop = false;
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonNext.BackgroundImage = global::JeuRonron.Properties.Resources.button_next;
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNext.Location = new System.Drawing.Point(4, 177);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 59);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.buttonPrevious);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(82, 442);
            this.panelLeft.TabIndex = 2;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonPrevious.BackgroundImage = global::JeuRonron.Properties.Resources.button_previous;
            this.buttonPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrevious.Location = new System.Drawing.Point(0, 168);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 59);
            this.buttonPrevious.TabIndex = 0;
            this.buttonPrevious.UseVisualStyleBackColor = true;
            // 
            // CharSelectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBackground);
            this.Controls.Add(this.panel1);
            this.Name = "CharSelectionControl";
            this.Size = new System.Drawing.Size(816, 489);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel1.ResumeLayout(false);
            this.panelBackground.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btSettings)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel panelChar;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox btSettings;
        private RoundButton buttonNext;
        private System.Windows.Forms.Panel panelLeft;
        private RoundButton buttonPrevious;
    }
}

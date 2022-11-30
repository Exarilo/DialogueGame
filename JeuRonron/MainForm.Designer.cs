namespace JeuRonron
{
    partial class MainForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.charSelectionControl = new JeuRonron.CharSelectionControl();
            this.settingsControl = new JeuRonron.SettingsControl();
            this.SuspendLayout();
            // 
            // charSelectionControl
            // 
            this.charSelectionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.charSelectionControl.Location = new System.Drawing.Point(0, 0);
            this.charSelectionControl.Name = "charSelectionControl";
            this.charSelectionControl.Size = new System.Drawing.Size(800, 450);
            this.charSelectionControl.TabIndex = 0;
            // 
            // settingsControl
            // 
            this.settingsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsControl.Location = new System.Drawing.Point(0, 0);
            this.settingsControl.Name = "settingsControl";
            this.settingsControl.Size = new System.Drawing.Size(800, 450);
            this.settingsControl.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.settingsControl);
            this.Controls.Add(this.charSelectionControl);
            this.Name = "MainForm";
            this.Text = "Selection des personnages";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.MainForm_ControlAdded);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Scene scene1;
        private CharSelectionControl charSelectionControl;
        private SettingsControl settingsControl;
    }
}
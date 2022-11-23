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
            this.panelGame = new System.Windows.Forms.Panel();
            this.LabelSceneName = new System.Windows.Forms.Label();
            this.btSelect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.LabelSceneName);
            this.panelGame.Controls.Add(this.btSelect);
            this.panelGame.Controls.Add(this.btPrevious);
            this.panelGame.Controls.Add(this.btNext);
            this.panelGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGame.Location = new System.Drawing.Point(0, 0);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(800, 450);
            this.panelGame.TabIndex = 0;
            // 
            // LabelSceneName
            // 
            this.LabelSceneName.AutoSize = true;
            this.LabelSceneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSceneName.Location = new System.Drawing.Point(0, 0);
            this.LabelSceneName.Name = "LabelSceneName";
            this.LabelSceneName.Size = new System.Drawing.Size(66, 24);
            this.LabelSceneName.TabIndex = 9;
            this.LabelSceneName.Text = "label1";
            // 
            // btSelect
            // 
            this.btSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btSelect.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelect.Location = new System.Drawing.Point(0, 412);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(800, 38);
            this.btSelect.TabIndex = 8;
            this.btSelect.Text = "SELECT";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            this.btSelect.MouseLeave += new System.EventHandler(this.btSelect_MouseLeave);
            this.btSelect.MouseHover += new System.EventHandler(this.btSelect_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelGame);
            this.Name = "MainForm";
            this.Text = "Selection des personnages";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.MainForm_ControlAdded);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Label LabelSceneName;
        private System.Windows.Forms.Button btSelect;
        private RoundButton btPrevious;
        private RoundButton btNext;
        private System.Windows.Forms.Timer timer1;
        private Scene scene1;
    }
}


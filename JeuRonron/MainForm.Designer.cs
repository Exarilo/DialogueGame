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
            this.btSelect = new System.Windows.Forms.Button();
            this.LabelSceneName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btPrevious = new JeuRonron.RoundButton();
            this.btNext = new JeuRonron.RoundButton();
            this.SuspendLayout();
            // 
            // btSelect
            // 
            this.btSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btSelect.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelect.Location = new System.Drawing.Point(0, 412);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(800, 38);
            this.btSelect.TabIndex = 2;
            this.btSelect.Text = "SELECT";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            this.btSelect.MouseLeave += new System.EventHandler(this.btSelect_MouseLeave);
            this.btSelect.MouseHover += new System.EventHandler(this.btSelect_MouseHover);
            // 
            // LabelSceneName
            // 
            this.LabelSceneName.AutoSize = true;
            this.LabelSceneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSceneName.Location = new System.Drawing.Point(0, 0);
            this.LabelSceneName.Name = "LabelSceneName";
            this.LabelSceneName.Size = new System.Drawing.Size(66, 24);
            this.LabelSceneName.TabIndex = 3;
            this.LabelSceneName.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btPrevious
            // 
            this.btPrevious.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPrevious.Location = new System.Drawing.Point(12, 193);
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.Size = new System.Drawing.Size(68, 53);
            this.btPrevious.TabIndex = 7;
            this.btPrevious.UseVisualStyleBackColor = true;
            this.btPrevious.Click += new System.EventHandler(this.btPreviousChar_Click);
            // 
            // btNext
            // 
            this.btNext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNext.Location = new System.Drawing.Point(720, 205);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(68, 53);
            this.btNext.TabIndex = 6;
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNextChar_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPrevious);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.LabelSceneName);
            this.Controls.Add(this.btSelect);
            this.Name = "MainForm";
            this.Text = "Selection des personnages";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.MainForm_ControlAdded);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Label LabelSceneName;
        private System.Windows.Forms.Timer timer1;
        private RoundButton btPrevious;
        private RoundButton btNext;
    }
}


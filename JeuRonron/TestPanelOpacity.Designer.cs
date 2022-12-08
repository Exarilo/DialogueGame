namespace JeuRonron
{
    partial class TestPanelOpacity
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
            this.button1 = new System.Windows.Forms.Button();
            this.trasnparentPanel1 = new JeuRonron.TrasnparentPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // trasnparentPanel1
            // 
            this.trasnparentPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trasnparentPanel1.Location = new System.Drawing.Point(0, 0);
            this.trasnparentPanel1.Name = "trasnparentPanel1";
            this.trasnparentPanel1.Size = new System.Drawing.Size(800, 450);
            this.trasnparentPanel1.TabIndex = 1;
            // 
            // TestPanelOpacity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trasnparentPanel1);
            this.Controls.Add(this.button1);
            this.Name = "TestPanelOpacity";
            this.Text = "TestPanelOpacity";
            this.Load += new System.EventHandler(this.TestPanelOpacity_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private TrasnparentPanel trasnparentPanel1;
    }
}
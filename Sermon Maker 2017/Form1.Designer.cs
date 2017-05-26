namespace Sermon_Maker_2017
{
    partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.btnGetStarted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetStarted
            // 
            this.btnGetStarted.Location = new System.Drawing.Point(107, 309);
            this.btnGetStarted.Name = "btnGetStarted";
            this.btnGetStarted.Size = new System.Drawing.Size(171, 23);
            this.btnGetStarted.TabIndex = 0;
            this.btnGetStarted.Text = "Get Started...";
            this.btnGetStarted.UseVisualStyleBackColor = true;
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Sermon_Maker_2017.Properties.Resources.Sermon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.btnGetStarted);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Sermon Maker 2017";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetStarted;
    }
}


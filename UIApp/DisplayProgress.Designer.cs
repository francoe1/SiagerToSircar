namespace UIApp
{
    partial class DisplayProgress
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
            this._progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // _progressBar
            // 
            this._progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._progressBar.Location = new System.Drawing.Point(0, 0);
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(205, 10);
            this._progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this._progressBar.TabIndex = 0;
            this._progressBar.UseWaitCursor = true;
            // 
            // DisplayProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 10);
            this.Controls.Add(this._progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayProgress";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar _progressBar;
    }
}
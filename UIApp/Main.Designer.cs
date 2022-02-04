namespace UIApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this._btnPercepciones = new System.Windows.Forms.Button();
            this._btnRetenciones = new System.Windows.Forms.Button();
            this._calculateAlicuota = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // _btnPercepciones
            // 
            this._btnPercepciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnPercepciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnPercepciones.Location = new System.Drawing.Point(13, 13);
            this._btnPercepciones.Name = "_btnPercepciones";
            this._btnPercepciones.Size = new System.Drawing.Size(259, 23);
            this._btnPercepciones.TabIndex = 0;
            this._btnPercepciones.TabStop = false;
            this._btnPercepciones.Text = "Percepciones (Siager > Sircar)";
            this._btnPercepciones.UseVisualStyleBackColor = true;
            // 
            // _btnRetenciones
            // 
            this._btnRetenciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnRetenciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnRetenciones.Location = new System.Drawing.Point(13, 42);
            this._btnRetenciones.Name = "_btnRetenciones";
            this._btnRetenciones.Size = new System.Drawing.Size(259, 23);
            this._btnRetenciones.TabIndex = 0;
            this._btnRetenciones.TabStop = false;
            this._btnRetenciones.Text = "Retenciones (Siager > Sircard)";
            this._btnRetenciones.UseVisualStyleBackColor = true;
            // 
            // _calculateAlicuota
            // 
            this._calculateAlicuota.AutoSize = true;
            this._calculateAlicuota.Location = new System.Drawing.Point(13, 72);
            this._calculateAlicuota.Name = "_calculateAlicuota";
            this._calculateAlicuota.Size = new System.Drawing.Size(105, 17);
            this._calculateAlicuota.TabIndex = 1;
            this._calculateAlicuota.Text = "Calcular Alicuota";
            this._calculateAlicuota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._calculateAlicuota.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this._calculateAlicuota);
            this.Controls.Add(this._btnRetenciones);
            this.Controls.Add(this._btnPercepciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siager a Sircar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnPercepciones;
        private System.Windows.Forms.Button _btnRetenciones;
        private System.Windows.Forms.CheckBox _calculateAlicuota;
    }
}


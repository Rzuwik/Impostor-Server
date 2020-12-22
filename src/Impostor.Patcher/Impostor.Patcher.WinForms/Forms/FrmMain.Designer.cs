namespace Impostor.Patcher.WinForms.Forms
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label2 = new System.Windows.Forms.Label();
            this.beta = new System.Windows.Forms.Button();
            this.lblUrl = new System.Windows.Forms.Label();
            this.stable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 91);
            this.label2.TabIndex = 0;
            this.label2.Text = "Witaj!\r\n\r\nKliknij w przycisk \"Impostors.ga\", aby grać na\r\noficjalnym serwerze.\r\n\r" +
    "\nJeśli odbywają się betatesty danego trybu,\r\nwybierz opcję \"Impostors.ga - Beta\"" +
    "";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // beta
            // 
            this.beta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beta.Location = new System.Drawing.Point(12, 125);
            this.beta.Name = "beta";
            this.beta.Size = new System.Drawing.Size(118, 22);
            this.beta.TabIndex = 3;
            this.beta.Text = "Impostors.ga";
            this.beta.UseVisualStyleBackColor = true;
            this.beta.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUrl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblUrl.Location = new System.Drawing.Point(155, 156);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(116, 13);
            this.lblUrl.TabIndex = 5;
            this.lblUrl.Text = "https://impostors.ga/";
            this.lblUrl.Click += new System.EventHandler(this.lblUrl_Click);
            // 
            // stable
            // 
            this.stable.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stable.Location = new System.Drawing.Point(149, 125);
            this.stable.Name = "stable";
            this.stable.Size = new System.Drawing.Size(122, 22);
            this.stable.TabIndex = 7;
            this.stable.Text = "Impostors.ga - Beta";
            this.stable.UseVisualStyleBackColor = true;
            this.stable.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 178);
            this.Controls.Add(this.stable);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.beta);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impostors.ga";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button beta;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Button stable;
    }
}
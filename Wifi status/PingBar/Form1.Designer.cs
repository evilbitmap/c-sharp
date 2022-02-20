
namespace PingBar
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelWifiStatus = new System.Windows.Forms.Label();
            this.timerCheckWifiStatus = new System.Windows.Forms.Timer(this.components);
            this.labelPingStatus = new System.Windows.Forms.Label();
            this.timerStopper = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timerIsFocused = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWifiStatus
            // 
            this.labelWifiStatus.AutoSize = true;
            this.labelWifiStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelWifiStatus.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWifiStatus.ForeColor = System.Drawing.Color.Red;
            this.labelWifiStatus.Location = new System.Drawing.Point(6, 16);
            this.labelWifiStatus.Name = "labelWifiStatus";
            this.labelWifiStatus.Size = new System.Drawing.Size(88, 14);
            this.labelWifiStatus.TabIndex = 0;
            this.labelWifiStatus.Text = "DISCONNECTED";
            // 
            // timerCheckWifiStatus
            // 
            this.timerCheckWifiStatus.Interval = 1000;
            this.timerCheckWifiStatus.Tick += new System.EventHandler(this.timerCheckWifiStatus_Tick);
            // 
            // labelPingStatus
            // 
            this.labelPingStatus.AutoSize = true;
            this.labelPingStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPingStatus.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPingStatus.ForeColor = System.Drawing.Color.White;
            this.labelPingStatus.Location = new System.Drawing.Point(6, 34);
            this.labelPingStatus.Name = "labelPingStatus";
            this.labelPingStatus.Size = new System.Drawing.Size(46, 14);
            this.labelPingStatus.TabIndex = 1;
            this.labelPingStatus.Text = "Ping: ...";
            // 
            // timerStopper
            // 
            this.timerStopper.Interval = 40;
            this.timerStopper.Tick += new System.EventHandler(this.timerStopper_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labelWifiStatus);
            this.groupBox1.Controls.Add(this.labelPingStatus);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 58);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // timerIsFocused
            // 
            this.timerIsFocused.Interval = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(134, 90);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWifiStatus;
        private System.Windows.Forms.Timer timerCheckWifiStatus;
        private System.Windows.Forms.Label labelPingStatus;
        private System.Windows.Forms.Timer timerStopper;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerIsFocused;
    }
}


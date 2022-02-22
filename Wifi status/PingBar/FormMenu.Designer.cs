
namespace PingBar
{
    partial class FormMenu
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
            this.timerCheckClosing = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPositionX = new System.Windows.Forms.TextBox();
            this.textBoxPositionY = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxTransparentTrue = new System.Windows.Forms.CheckBox();
            this.checkBoxTransparentFalse = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerCheckClosing
            // 
            this.timerCheckClosing.Interval = 40;
            this.timerCheckClosing.Tick += new System.EventHandler(this.timerCheckClosing_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 25);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPositionY);
            this.groupBox1.Controls.Add(this.textBoxPositionX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "X: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Y:";
            // 
            // textBoxPositionX
            // 
            this.textBoxPositionX.Location = new System.Drawing.Point(29, 19);
            this.textBoxPositionX.Name = "textBoxPositionX";
            this.textBoxPositionX.Size = new System.Drawing.Size(136, 20);
            this.textBoxPositionX.TabIndex = 2;
            // 
            // textBoxPositionY
            // 
            this.textBoxPositionY.Location = new System.Drawing.Point(29, 45);
            this.textBoxPositionY.Name = "textBoxPositionY";
            this.textBoxPositionY.Size = new System.Drawing.Size(136, 20);
            this.textBoxPositionY.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxTransparentFalse);
            this.groupBox2.Controls.Add(this.checkBoxTransparentTrue);
            this.groupBox2.Location = new System.Drawing.Point(208, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 75);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transparent background";
            // 
            // checkBoxTransparentTrue
            // 
            this.checkBoxTransparentTrue.AutoSize = true;
            this.checkBoxTransparentTrue.Location = new System.Drawing.Point(6, 19);
            this.checkBoxTransparentTrue.Name = "checkBoxTransparentTrue";
            this.checkBoxTransparentTrue.Size = new System.Drawing.Size(48, 17);
            this.checkBoxTransparentTrue.TabIndex = 0;
            this.checkBoxTransparentTrue.Text = "True";
            this.checkBoxTransparentTrue.UseVisualStyleBackColor = true;
            this.checkBoxTransparentTrue.CheckedChanged += new System.EventHandler(this.checkBoxTransparentTrue_CheckedChanged);
            // 
            // checkBoxTransparentFalse
            // 
            this.checkBoxTransparentFalse.AutoSize = true;
            this.checkBoxTransparentFalse.Location = new System.Drawing.Point(6, 45);
            this.checkBoxTransparentFalse.Name = "checkBoxTransparentFalse";
            this.checkBoxTransparentFalse.Size = new System.Drawing.Size(51, 17);
            this.checkBoxTransparentFalse.TabIndex = 1;
            this.checkBoxTransparentFalse.Text = "False";
            this.checkBoxTransparentFalse.UseVisualStyleBackColor = true;
            this.checkBoxTransparentFalse.CheckedChanged += new System.EventHandler(this.checkBoxTransparentFalse_CheckedChanged);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerCheckClosing;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPositionY;
        private System.Windows.Forms.TextBox textBoxPositionX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxTransparentFalse;
        private System.Windows.Forms.CheckBox checkBoxTransparentTrue;
    }
}
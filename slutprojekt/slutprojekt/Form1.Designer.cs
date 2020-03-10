namespace slutprojekt
{
    partial class Form1
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
            this.btnEasy = new System.Windows.Forms.Button();
            this.timerPress = new System.Windows.Forms.Timer(this.components);
            this.lblNivå = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timerStart = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.SystemColors.Control;
            this.btnEasy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEasy.Location = new System.Drawing.Point(23, 12);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(79, 29);
            this.btnEasy.TabIndex = 0;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.Button1_Click);
            // 
            // timerPress
            // 
            this.timerPress.Interval = 300;
            this.timerPress.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblNivå
            // 
            this.lblNivå.AutoSize = true;
            this.lblNivå.Location = new System.Drawing.Point(195, 20);
            this.lblNivå.Name = "lblNivå";
            this.lblNivå.Size = new System.Drawing.Size(0, 13);
            this.lblNivå.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(333, 15);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // timerStart
            // 
            this.timerStart.Tick += new System.EventHandler(this.TimerStart_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblNivå);
            this.Controls.Add(this.btnEasy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Timer timerPress;
        private System.Windows.Forms.Label lblNivå;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timerStart;
    }
}


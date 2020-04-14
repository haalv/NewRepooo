namespace knappSpel
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
            this.btnStart = new System.Windows.Forms.Button();
            this.timerKlick = new System.Windows.Forms.Timer(this.components);
            this.simulationTimer = new System.Windows.Forms.Timer(this.components);
            this.lblNivå = new System.Windows.Forms.Label();
            this.lblLiv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(26, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Starta";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timerKlick
            // 
            this.timerKlick.Interval = 300;
            this.timerKlick.Tick += new System.EventHandler(this.timerKlick_Tick);
            // 
            // simulationTimer
            // 
            this.simulationTimer.Interval = 600;
            this.simulationTimer.Tick += new System.EventHandler(this.simulationTimer_Tick);
            // 
            // lblNivå
            // 
            this.lblNivå.AutoSize = true;
            this.lblNivå.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivå.Location = new System.Drawing.Point(139, 17);
            this.lblNivå.Name = "lblNivå";
            this.lblNivå.Size = new System.Drawing.Size(0, 21);
            this.lblNivå.TabIndex = 1;
            // 
            // lblLiv
            // 
            this.lblLiv.AutoSize = true;
            this.lblLiv.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiv.Location = new System.Drawing.Point(300, 50);
            this.lblLiv.Name = "lblLiv";
            this.lblLiv.Size = new System.Drawing.Size(0, 21);
            this.lblLiv.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLiv);
            this.Controls.Add(this.lblNivå);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timerKlick;
        private System.Windows.Forms.Timer simulationTimer;
        private System.Windows.Forms.Label lblNivå;
        private System.Windows.Forms.Label lblLiv;
    }
}


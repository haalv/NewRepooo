﻿namespace knappSpel
{
    partial class KnappSpel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KnappSpel));
            this.btnStart = new System.Windows.Forms.Button();
            this.timerKlick = new System.Windows.Forms.Timer(this.components);
            this.simulationTimer = new System.Windows.Forms.Timer(this.components);
            this.lblNivå = new System.Windows.Forms.Label();
            this.lblLiv = new System.Windows.Forms.Label();
            this.lblPoäng = new System.Windows.Forms.Label();
            this.lblPoänglista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 44);
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
            this.lblNivå.BackColor = System.Drawing.Color.Transparent;
            this.lblNivå.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivå.Location = new System.Drawing.Point(139, 17);
            this.lblNivå.Name = "lblNivå";
            this.lblNivå.Size = new System.Drawing.Size(0, 21);
            this.lblNivå.TabIndex = 1;
            // 
            // lblLiv
            // 
            this.lblLiv.AutoSize = true;
            this.lblLiv.BackColor = System.Drawing.Color.Transparent;
            this.lblLiv.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiv.Location = new System.Drawing.Point(300, 50);
            this.lblLiv.Name = "lblLiv";
            this.lblLiv.Size = new System.Drawing.Size(0, 21);
            this.lblLiv.TabIndex = 2;
            // 
            // lblPoäng
            // 
            this.lblPoäng.AutoSize = true;
            this.lblPoäng.BackColor = System.Drawing.Color.Transparent;
            this.lblPoäng.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoäng.Location = new System.Drawing.Point(425, 15);
            this.lblPoäng.Name = "lblPoäng";
            this.lblPoäng.Size = new System.Drawing.Size(0, 32);
            this.lblPoäng.TabIndex = 3;
            // 
            // lblPoänglista
            // 
            this.lblPoänglista.AutoSize = true;
            this.lblPoänglista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPoänglista.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoänglista.Location = new System.Drawing.Point(575, 100);
            this.lblPoänglista.Name = "lblPoänglista";
            this.lblPoänglista.Size = new System.Drawing.Size(2, 25);
            this.lblPoänglista.TabIndex = 4;
            // 
            // KnappSpel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPoänglista);
            this.Controls.Add(this.lblPoäng);
            this.Controls.Add(this.lblLiv);
            this.Controls.Add(this.lblNivå);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KnappSpel";
            this.Text = "Knapp Spel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timerKlick;
        private System.Windows.Forms.Timer simulationTimer;
        private System.Windows.Forms.Label lblNivå;
        private System.Windows.Forms.Label lblLiv;
        private System.Windows.Forms.Label lblPoäng;
        private System.Windows.Forms.Label lblPoänglista;
    }
}


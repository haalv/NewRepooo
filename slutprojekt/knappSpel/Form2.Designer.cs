namespace knappSpel
{
    partial class Highscore_Lista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Highscore_Lista));
            this.btnLäggTillPoäng = new System.Windows.Forms.Button();
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVisaPoäng = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLäggTillPoäng
            // 
            this.btnLäggTillPoäng.Location = new System.Drawing.Point(172, 57);
            this.btnLäggTillPoäng.Name = "btnLäggTillPoäng";
            this.btnLäggTillPoäng.Size = new System.Drawing.Size(113, 23);
            this.btnLäggTillPoäng.TabIndex = 0;
            this.btnLäggTillPoäng.Text = "Lägg till High-score";
            this.btnLäggTillPoäng.UseVisualStyleBackColor = true;
            this.btnLäggTillPoäng.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxNamn
            // 
            this.tbxNamn.Location = new System.Drawing.Point(56, 59);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(100, 20);
            this.tbxNamn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Namn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "(Max 8 variabler)";
            // 
            // lblVisaPoäng
            // 
            this.lblVisaPoäng.AutoSize = true;
            this.lblVisaPoäng.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisaPoäng.Location = new System.Drawing.Point(166, 9);
            this.lblVisaPoäng.Name = "lblVisaPoäng";
            this.lblVisaPoäng.Size = new System.Drawing.Size(0, 32);
            this.lblVisaPoäng.TabIndex = 4;
            // 
            // Highscore_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 95);
            this.Controls.Add(this.lblVisaPoäng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNamn);
            this.Controls.Add(this.btnLäggTillPoäng);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Highscore_Lista";
            this.Text = "Highscore Lista";
            this.Activated += new System.EventHandler(this.Form2_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLäggTillPoäng;
        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVisaPoäng;
    }
}
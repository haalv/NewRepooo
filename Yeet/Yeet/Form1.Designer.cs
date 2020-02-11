namespace Yeet
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
            this.btnKör = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.tbxTecken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(325, 216);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(90, 23);
            this.btnKör.TabIndex = 0;
            this.btnKör.Text = "Visa Resultat";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.BtnKör_Click);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(325, 179);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(2, 15);
            this.lblShow.TabIndex = 1;
            this.lblShow.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tbxTecken
            // 
            this.tbxTecken.Location = new System.Drawing.Point(325, 137);
            this.tbxTecken.Name = "tbxTecken";
            this.tbxTecken.Size = new System.Drawing.Size(100, 20);
            this.tbxTecken.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tecken.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxTecken);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnKör);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.TextBox tbxTecken;
        private System.Windows.Forms.Label label2;
    }
}


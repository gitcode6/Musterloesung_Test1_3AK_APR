namespace Projektverwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstProjekte = new System.Windows.Forms.ListBox();
            this.cmdNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblKunde = new System.Windows.Forms.Label();
            this.lblProjektkosten = new System.Windows.Forms.Label();
            this.lblEinnahmen = new System.Windows.Forms.Label();
            this.lblProjektende = new System.Windows.Forms.Label();
            this.lblProjektbeginn = new System.Windows.Forms.Label();
            this.lblProjektname = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGewinn = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstProjekte
            // 
            this.lstProjekte.FormattingEnabled = true;
            this.lstProjekte.ItemHeight = 20;
            this.lstProjekte.Location = new System.Drawing.Point(14, 23);
            this.lstProjekte.Name = "lstProjekte";
            this.lstProjekte.Size = new System.Drawing.Size(368, 324);
            this.lstProjekte.TabIndex = 0;
            this.lstProjekte.SelectedIndexChanged += new System.EventHandler(this.lstProjekte_SelectedIndexChanged);
            // 
            // cmdNew
            // 
            this.cmdNew.Location = new System.Drawing.Point(14, 380);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(140, 48);
            this.cmdNew.TabIndex = 1;
            this.cmdNew.Text = "Neues Projekt";
            this.cmdNew.UseVisualStyleBackColor = true;
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Projektname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Projektbeginn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Projektende:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Einnahmen:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Projektkosten:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Kunde:";
            // 
            // lblKunde
            // 
            this.lblKunde.AutoSize = true;
            this.lblKunde.Location = new System.Drawing.Point(154, 282);
            this.lblKunde.Name = "lblKunde";
            this.lblKunde.Size = new System.Drawing.Size(14, 20);
            this.lblKunde.TabIndex = 10;
            this.lblKunde.Text = "-";
            // 
            // lblProjektkosten
            // 
            this.lblProjektkosten.AutoSize = true;
            this.lblProjektkosten.Location = new System.Drawing.Point(154, 205);
            this.lblProjektkosten.Name = "lblProjektkosten";
            this.lblProjektkosten.Size = new System.Drawing.Size(14, 20);
            this.lblProjektkosten.TabIndex = 11;
            this.lblProjektkosten.Text = "-";
            // 
            // lblEinnahmen
            // 
            this.lblEinnahmen.AutoSize = true;
            this.lblEinnahmen.Location = new System.Drawing.Point(154, 162);
            this.lblEinnahmen.Name = "lblEinnahmen";
            this.lblEinnahmen.Size = new System.Drawing.Size(14, 20);
            this.lblEinnahmen.TabIndex = 12;
            this.lblEinnahmen.Text = "-";
            // 
            // lblProjektende
            // 
            this.lblProjektende.AutoSize = true;
            this.lblProjektende.Location = new System.Drawing.Point(154, 124);
            this.lblProjektende.Name = "lblProjektende";
            this.lblProjektende.Size = new System.Drawing.Size(14, 20);
            this.lblProjektende.TabIndex = 13;
            this.lblProjektende.Text = "-";
            // 
            // lblProjektbeginn
            // 
            this.lblProjektbeginn.AutoSize = true;
            this.lblProjektbeginn.Location = new System.Drawing.Point(154, 82);
            this.lblProjektbeginn.Name = "lblProjektbeginn";
            this.lblProjektbeginn.Size = new System.Drawing.Size(14, 20);
            this.lblProjektbeginn.TabIndex = 14;
            this.lblProjektbeginn.Text = "-";
            // 
            // lblProjektname
            // 
            this.lblProjektname.AutoSize = true;
            this.lblProjektname.Location = new System.Drawing.Point(154, 42);
            this.lblProjektname.Name = "lblProjektname";
            this.lblProjektname.Size = new System.Drawing.Size(14, 20);
            this.lblProjektname.TabIndex = 15;
            this.lblProjektname.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGewinn);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblProjektname);
            this.groupBox1.Controls.Add(this.lblProjektbeginn);
            this.groupBox1.Controls.Add(this.lblProjektende);
            this.groupBox1.Controls.Add(this.lblEinnahmen);
            this.groupBox1.Controls.Add(this.lblProjektkosten);
            this.groupBox1.Controls.Add(this.lblKunde);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(412, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 323);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // lblGewinn
            // 
            this.lblGewinn.AutoSize = true;
            this.lblGewinn.Location = new System.Drawing.Point(154, 244);
            this.lblGewinn.Name = "lblGewinn";
            this.lblGewinn.Size = new System.Drawing.Size(14, 20);
            this.lblGewinn.TabIndex = 17;
            this.lblGewinn.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Gewinn:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdNew);
            this.Controls.Add(this.lstProjekte);
            this.Name = "Form1";
            this.Text = "Projektverwaltung";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstProjekte;
        private System.Windows.Forms.Button cmdNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblKunde;
        private System.Windows.Forms.Label lblProjektkosten;
        private System.Windows.Forms.Label lblEinnahmen;
        private System.Windows.Forms.Label lblProjektende;
        private System.Windows.Forms.Label lblProjektbeginn;
        private System.Windows.Forms.Label lblProjektname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGewinn;
        private System.Windows.Forms.Label label9;
    }
}


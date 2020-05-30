namespace SeminarskiRadPozoriste.FormeGlumac
{
    partial class IzmenaGlumcaDialog
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
            this.btnIzmeniGlumca = new System.Windows.Forms.Button();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.txtRadniStaz = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIzmeniGlumca
            // 
            this.btnIzmeniGlumca.BackColor = System.Drawing.Color.BurlyWood;
            this.btnIzmeniGlumca.Location = new System.Drawing.Point(175, 335);
            this.btnIzmeniGlumca.Name = "btnIzmeniGlumca";
            this.btnIzmeniGlumca.Size = new System.Drawing.Size(116, 32);
            this.btnIzmeniGlumca.TabIndex = 23;
            this.btnIzmeniGlumca.Text = "Izmeni glumca";
            this.btnIzmeniGlumca.UseVisualStyleBackColor = false;
            this.btnIzmeniGlumca.Click += new System.EventHandler(this.btnIzmeniGlumca_Click);
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(207, 185);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(200, 22);
            this.dtpDatumRodjenja.TabIndex = 21;
            // 
            // txtRadniStaz
            // 
            this.txtRadniStaz.Location = new System.Drawing.Point(207, 256);
            this.txtRadniStaz.Name = "txtRadniStaz";
            this.txtRadniStaz.Size = new System.Drawing.Size(200, 22);
            this.txtRadniStaz.TabIndex = 20;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(207, 115);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(200, 22);
            this.txtPrezime.TabIndex = 19;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(207, 51);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(200, 22);
            this.txtIme.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(54, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Radni staž:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(54, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Datum rođenja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ime:";
            // 
            // IzmenaGlumcaDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(461, 434);
            this.Controls.Add(this.btnIzmeniGlumca);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.txtRadniStaz);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "IzmenaGlumcaDialog";
            this.Text = "IzmenaGlumcaDialog";
            this.Load += new System.EventHandler(this.IzmenaGlumcaDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzmeniGlumca;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.TextBox txtRadniStaz;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
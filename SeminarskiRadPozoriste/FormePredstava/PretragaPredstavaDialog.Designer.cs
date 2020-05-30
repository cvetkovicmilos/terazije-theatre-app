namespace SeminarskiRadPozoriste.FormePredstava
{
    partial class PretragaPredstavaDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtBrojGlumaca = new System.Windows.Forms.TextBox();
            this.txtReditelj = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwUloge = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dgwZanrovi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUloge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZanrovi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv predstave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum postavljanja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj glumaca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reditelj:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(218, 31);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(134, 22);
            this.txtNaziv.TabIndex = 4;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(218, 88);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(134, 22);
            this.txtDatum.TabIndex = 5;
            // 
            // txtBrojGlumaca
            // 
            this.txtBrojGlumaca.Location = new System.Drawing.Point(218, 145);
            this.txtBrojGlumaca.Name = "txtBrojGlumaca";
            this.txtBrojGlumaca.Size = new System.Drawing.Size(134, 22);
            this.txtBrojGlumaca.TabIndex = 6;
            // 
            // txtReditelj
            // 
            this.txtReditelj.Location = new System.Drawing.Point(218, 204);
            this.txtReditelj.Name = "txtReditelj";
            this.txtReditelj.Size = new System.Drawing.Size(134, 22);
            this.txtReditelj.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwUloge);
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(383, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 382);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista uloga";
            // 
            // dgwUloge
            // 
            this.dgwUloge.AllowUserToAddRows = false;
            this.dgwUloge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUloge.BackgroundColor = System.Drawing.Color.White;
            this.dgwUloge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUloge.Location = new System.Drawing.Point(6, 22);
            this.dgwUloge.Name = "dgwUloge";
            this.dgwUloge.RowHeadersWidth = 51;
            this.dgwUloge.RowTemplate.Height = 24;
            this.dgwUloge.Size = new System.Drawing.Size(551, 354);
            this.dgwUloge.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Zanrovi:";
            // 
            // dgwZanrovi
            // 
            this.dgwZanrovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwZanrovi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwZanrovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwZanrovi.Location = new System.Drawing.Point(165, 269);
            this.dgwZanrovi.Name = "dgwZanrovi";
            this.dgwZanrovi.RowHeadersWidth = 51;
            this.dgwZanrovi.RowTemplate.Height = 24;
            this.dgwZanrovi.Size = new System.Drawing.Size(187, 125);
            this.dgwZanrovi.TabIndex = 10;
            // 
            // PretragaPredstavaDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(958, 406);
            this.Controls.Add(this.dgwZanrovi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtReditelj);
            this.Controls.Add(this.txtBrojGlumaca);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PretragaPredstavaDialog";
            this.Text = "PretragaPredstavaDialog";
            this.Load += new System.EventHandler(this.PretragaPredstavaDialog_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUloge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZanrovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtBrojGlumaca;
        private System.Windows.Forms.TextBox txtReditelj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgwUloge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgwZanrovi;
    }
}
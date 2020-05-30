namespace SeminarskiRadPozoriste.FormePredstava
{
    partial class IzmenaPredstaveDialog
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.cmbGlumac = new System.Windows.Forms.ComboBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.dgwUloge = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObrisiZanr = new System.Windows.Forms.Button();
            this.dgwZanrovi = new System.Windows.Forms.DataGridView();
            this.txtBrojGlumaca = new System.Windows.Forms.TextBox();
            this.cmbZanr = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodajZanr = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnIzmenaPredstave = new System.Windows.Forms.Button();
            this.dtpDatumPostavljanja = new System.Windows.Forms.DateTimePicker();
            this.txtReditelj = new System.Windows.Forms.TextBox();
            this.txtNazivPredstave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUloge)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZanrovi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnObrisi);
            this.groupBox2.Controls.Add(this.cmbGlumac);
            this.groupBox2.Controls.Add(this.btnSacuvaj);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTip);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNaziv);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnIzaberi);
            this.groupBox2.Controls.Add(this.dgwUloge);
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(390, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 509);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Izmena uloga";
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.BurlyWood;
            this.btnObrisi.ForeColor = System.Drawing.Color.Black;
            this.btnObrisi.Location = new System.Drawing.Point(650, 456);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(128, 33);
            this.btnObrisi.TabIndex = 14;
            this.btnObrisi.Text = "Obrisi ulogu";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // cmbGlumac
            // 
            this.cmbGlumac.FormattingEnabled = true;
            this.cmbGlumac.Location = new System.Drawing.Point(108, 465);
            this.cmbGlumac.Name = "cmbGlumac";
            this.cmbGlumac.Size = new System.Drawing.Size(200, 24);
            this.cmbGlumac.TabIndex = 13;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSacuvaj.ForeColor = System.Drawing.Color.Black;
            this.btnSacuvaj.Location = new System.Drawing.Point(499, 456);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(128, 33);
            this.btnSacuvaj.TabIndex = 11;
            this.btnSacuvaj.Text = "Sačuvaj ulogu";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 465);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Glumac:";
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(108, 403);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(200, 22);
            this.txtTip.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tip:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(108, 343);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(200, 22);
            this.txtNaziv.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Naziv:";
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.BackColor = System.Drawing.Color.BurlyWood;
            this.btnIzaberi.ForeColor = System.Drawing.Color.Black;
            this.btnIzaberi.Location = new System.Drawing.Point(650, 343);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(128, 33);
            this.btnIzaberi.TabIndex = 3;
            this.btnIzaberi.Text = "Izaberi ulogu";
            this.btnIzaberi.UseVisualStyleBackColor = false;
            this.btnIzaberi.Click += new System.EventHandler(this.btnIzaberi_Click);
            // 
            // dgwUloge
            // 
            this.dgwUloge.AllowUserToAddRows = false;
            this.dgwUloge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUloge.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwUloge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUloge.Location = new System.Drawing.Point(6, 31);
            this.dgwUloge.Name = "dgwUloge";
            this.dgwUloge.RowHeadersWidth = 51;
            this.dgwUloge.RowTemplate.Height = 24;
            this.dgwUloge.Size = new System.Drawing.Size(772, 286);
            this.dgwUloge.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObrisiZanr);
            this.groupBox1.Controls.Add(this.dgwZanrovi);
            this.groupBox1.Controls.Add(this.txtBrojGlumaca);
            this.groupBox1.Controls.Add(this.cmbZanr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDodajZanr);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnIzmenaPredstave);
            this.groupBox1.Controls.Add(this.dtpDatumPostavljanja);
            this.groupBox1.Controls.Add(this.txtReditelj);
            this.groupBox1.Controls.Add(this.txtNazivPredstave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 509);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izmena predstave";
            // 
            // btnObrisiZanr
            // 
            this.btnObrisiZanr.BackColor = System.Drawing.Color.BurlyWood;
            this.btnObrisiZanr.ForeColor = System.Drawing.Color.Black;
            this.btnObrisiZanr.Location = new System.Drawing.Point(189, 429);
            this.btnObrisiZanr.Name = "btnObrisiZanr";
            this.btnObrisiZanr.Size = new System.Drawing.Size(177, 30);
            this.btnObrisiZanr.TabIndex = 14;
            this.btnObrisiZanr.Text = "Obrisi žanr";
            this.btnObrisiZanr.UseVisualStyleBackColor = false;
            this.btnObrisiZanr.Click += new System.EventHandler(this.btnObrisiZanr_Click);
            // 
            // dgwZanrovi
            // 
            this.dgwZanrovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwZanrovi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwZanrovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwZanrovi.Location = new System.Drawing.Point(151, 263);
            this.dgwZanrovi.Name = "dgwZanrovi";
            this.dgwZanrovi.RowHeadersWidth = 51;
            this.dgwZanrovi.RowTemplate.Height = 24;
            this.dgwZanrovi.Size = new System.Drawing.Size(215, 102);
            this.dgwZanrovi.TabIndex = 13;
            // 
            // txtBrojGlumaca
            // 
            this.txtBrojGlumaca.Location = new System.Drawing.Point(189, 144);
            this.txtBrojGlumaca.Name = "txtBrojGlumaca";
            this.txtBrojGlumaca.Size = new System.Drawing.Size(177, 22);
            this.txtBrojGlumaca.TabIndex = 12;
            // 
            // cmbZanr
            // 
            this.cmbZanr.FormattingEnabled = true;
            this.cmbZanr.Location = new System.Drawing.Point(151, 384);
            this.cmbZanr.Name = "cmbZanr";
            this.cmbZanr.Size = new System.Drawing.Size(215, 24);
            this.cmbZanr.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Broj glumaca:";
            // 
            // btnDodajZanr
            // 
            this.btnDodajZanr.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDodajZanr.ForeColor = System.Drawing.Color.Black;
            this.btnDodajZanr.Location = new System.Drawing.Point(9, 429);
            this.btnDodajZanr.Name = "btnDodajZanr";
            this.btnDodajZanr.Size = new System.Drawing.Size(174, 30);
            this.btnDodajZanr.TabIndex = 10;
            this.btnDodajZanr.Text = "Dodaj žanr";
            this.btnDodajZanr.UseVisualStyleBackColor = false;
            this.btnDodajZanr.Click += new System.EventHandler(this.btnDodajZanr_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Žanr:";
            // 
            // btnIzmenaPredstave
            // 
            this.btnIzmenaPredstave.BackColor = System.Drawing.Color.BurlyWood;
            this.btnIzmenaPredstave.ForeColor = System.Drawing.Color.Black;
            this.btnIzmenaPredstave.Location = new System.Drawing.Point(9, 465);
            this.btnIzmenaPredstave.Name = "btnIzmenaPredstave";
            this.btnIzmenaPredstave.Size = new System.Drawing.Size(357, 33);
            this.btnIzmenaPredstave.TabIndex = 7;
            this.btnIzmenaPredstave.Text = "Izmeni predstavu";
            this.btnIzmenaPredstave.UseVisualStyleBackColor = false;
            this.btnIzmenaPredstave.Click += new System.EventHandler(this.btnIzmenaPredstave_Click);
            // 
            // dtpDatumPostavljanja
            // 
            this.dtpDatumPostavljanja.Location = new System.Drawing.Point(189, 83);
            this.dtpDatumPostavljanja.Name = "dtpDatumPostavljanja";
            this.dtpDatumPostavljanja.Size = new System.Drawing.Size(177, 22);
            this.dtpDatumPostavljanja.TabIndex = 6;
            // 
            // txtReditelj
            // 
            this.txtReditelj.Location = new System.Drawing.Point(189, 201);
            this.txtReditelj.Name = "txtReditelj";
            this.txtReditelj.Size = new System.Drawing.Size(177, 22);
            this.txtReditelj.TabIndex = 5;
            // 
            // txtNazivPredstave
            // 
            this.txtNazivPredstave.Location = new System.Drawing.Point(189, 31);
            this.txtNazivPredstave.Name = "txtNazivPredstave";
            this.txtNazivPredstave.Size = new System.Drawing.Size(177, 22);
            this.txtNazivPredstave.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reditelj:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum postavljanja:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv predstave:";
            // 
            // IzmenaPredstaveDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1192, 533);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "IzmenaPredstaveDialog";
            this.Text = "IzmenaPredstaveDialog";
            this.Load += new System.EventHandler(this.IzmenaPredstaveDialog_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUloge)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZanrovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgwUloge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodajZanr;
        private System.Windows.Forms.ComboBox cmbZanr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIzmenaPredstave;
        private System.Windows.Forms.DateTimePicker dtpDatumPostavljanja;
        private System.Windows.Forms.TextBox txtReditelj;
        private System.Windows.Forms.TextBox txtNazivPredstave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrojGlumaca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIzaberi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbGlumac;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnObrisiZanr;
        private System.Windows.Forms.DataGridView dgwZanrovi;
    }
}
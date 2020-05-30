namespace SeminarskiRadPozoriste.FormePredstava
{
    partial class UnosPredstave
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
            this.gbPredstava = new System.Windows.Forms.GroupBox();
            this.btnZanr = new System.Windows.Forms.Button();
            this.dgwZanr = new System.Windows.Forms.DataGridView();
            this.btnDodajZanr = new System.Windows.Forms.Button();
            this.cmbZanr = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUnosPredstave = new System.Windows.Forms.Button();
            this.dtpDatumPostavljanja = new System.Windows.Forms.DateTimePicker();
            this.txtReditelj = new System.Windows.Forms.TextBox();
            this.txtNazivPredstave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUloga = new System.Windows.Forms.GroupBox();
            this.txtTrenutnaPredstava = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGlumac = new System.Windows.Forms.ComboBox();
            this.btnDodajUloge = new System.Windows.Forms.Button();
            this.dgwUloge = new System.Windows.Forms.DataGridView();
            this.btnKreirajUlogu = new System.Windows.Forms.Button();
            this.gbPredstava.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZanr)).BeginInit();
            this.gbUloga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUloge)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPredstava
            // 
            this.gbPredstava.Controls.Add(this.btnZanr);
            this.gbPredstava.Controls.Add(this.dgwZanr);
            this.gbPredstava.Controls.Add(this.btnDodajZanr);
            this.gbPredstava.Controls.Add(this.cmbZanr);
            this.gbPredstava.Controls.Add(this.label7);
            this.gbPredstava.Controls.Add(this.btnUnosPredstave);
            this.gbPredstava.Controls.Add(this.dtpDatumPostavljanja);
            this.gbPredstava.Controls.Add(this.txtReditelj);
            this.gbPredstava.Controls.Add(this.txtNazivPredstave);
            this.gbPredstava.Controls.Add(this.label4);
            this.gbPredstava.Controls.Add(this.label2);
            this.gbPredstava.Controls.Add(this.label1);
            this.gbPredstava.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPredstava.ForeColor = System.Drawing.Color.Gray;
            this.gbPredstava.Location = new System.Drawing.Point(12, 12);
            this.gbPredstava.Name = "gbPredstava";
            this.gbPredstava.Size = new System.Drawing.Size(372, 509);
            this.gbPredstava.TabIndex = 0;
            this.gbPredstava.TabStop = false;
            this.gbPredstava.Text = "Unos predstave";
            // 
            // btnZanr
            // 
            this.btnZanr.BackColor = System.Drawing.Color.BurlyWood;
            this.btnZanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZanr.ForeColor = System.Drawing.Color.Black;
            this.btnZanr.Location = new System.Drawing.Point(9, 409);
            this.btnZanr.Name = "btnZanr";
            this.btnZanr.Size = new System.Drawing.Size(129, 30);
            this.btnZanr.TabIndex = 12;
            this.btnZanr.Text = "Dodaj žanr";
            this.btnZanr.UseVisualStyleBackColor = false;
            this.btnZanr.Click += new System.EventHandler(this.btnZanr_Click);
            // 
            // dgwZanr
            // 
            this.dgwZanr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwZanr.BackgroundColor = System.Drawing.Color.White;
            this.dgwZanr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwZanr.Location = new System.Drawing.Point(9, 285);
            this.dgwZanr.Name = "dgwZanr";
            this.dgwZanr.RowHeadersWidth = 51;
            this.dgwZanr.RowTemplate.Height = 24;
            this.dgwZanr.Size = new System.Drawing.Size(347, 101);
            this.dgwZanr.TabIndex = 11;
            // 
            // btnDodajZanr
            // 
            this.btnDodajZanr.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDodajZanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajZanr.ForeColor = System.Drawing.Color.Black;
            this.btnDodajZanr.Location = new System.Drawing.Point(227, 409);
            this.btnDodajZanr.Name = "btnDodajZanr";
            this.btnDodajZanr.Size = new System.Drawing.Size(129, 30);
            this.btnDodajZanr.TabIndex = 10;
            this.btnDodajZanr.Text = "Dodaj novi žanr";
            this.btnDodajZanr.UseVisualStyleBackColor = false;
            this.btnDodajZanr.Click += new System.EventHandler(this.btnDodajZanr_Click);
            // 
            // cmbZanr
            // 
            this.cmbZanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbZanr.FormattingEnabled = true;
            this.cmbZanr.Location = new System.Drawing.Point(169, 240);
            this.cmbZanr.Name = "cmbZanr";
            this.cmbZanr.Size = new System.Drawing.Size(187, 24);
            this.cmbZanr.TabIndex = 9;
            this.cmbZanr.DropDown += new System.EventHandler(this.cmbZanr_DropDown);
            this.cmbZanr.SelectedIndexChanged += new System.EventHandler(this.cmbZanr_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Žanr:";
            // 
            // btnUnosPredstave
            // 
            this.btnUnosPredstave.BackColor = System.Drawing.Color.BurlyWood;
            this.btnUnosPredstave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnosPredstave.ForeColor = System.Drawing.Color.Black;
            this.btnUnosPredstave.Location = new System.Drawing.Point(115, 462);
            this.btnUnosPredstave.Name = "btnUnosPredstave";
            this.btnUnosPredstave.Size = new System.Drawing.Size(129, 41);
            this.btnUnosPredstave.TabIndex = 7;
            this.btnUnosPredstave.Text = "Kreiraj predstavu";
            this.btnUnosPredstave.UseVisualStyleBackColor = false;
            this.btnUnosPredstave.Click += new System.EventHandler(this.btnUnosPredstave_Click);
            // 
            // dtpDatumPostavljanja
            // 
            this.dtpDatumPostavljanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumPostavljanja.Location = new System.Drawing.Point(200, 120);
            this.dtpDatumPostavljanja.Name = "dtpDatumPostavljanja";
            this.dtpDatumPostavljanja.Size = new System.Drawing.Size(156, 22);
            this.dtpDatumPostavljanja.TabIndex = 6;
            // 
            // txtReditelj
            // 
            this.txtReditelj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReditelj.Location = new System.Drawing.Point(200, 181);
            this.txtReditelj.Name = "txtReditelj";
            this.txtReditelj.Size = new System.Drawing.Size(156, 22);
            this.txtReditelj.TabIndex = 5;
            // 
            // txtNazivPredstave
            // 
            this.txtNazivPredstave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivPredstave.Location = new System.Drawing.Point(200, 68);
            this.txtNazivPredstave.Name = "txtNazivPredstave";
            this.txtNazivPredstave.Size = new System.Drawing.Size(156, 22);
            this.txtNazivPredstave.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 181);
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
            this.label2.Location = new System.Drawing.Point(6, 122);
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
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv predstave:";
            // 
            // gbUloga
            // 
            this.gbUloga.Controls.Add(this.txtTrenutnaPredstava);
            this.gbUloga.Controls.Add(this.label6);
            this.gbUloga.Controls.Add(this.label5);
            this.gbUloga.Controls.Add(this.cmbGlumac);
            this.gbUloga.Controls.Add(this.btnDodajUloge);
            this.gbUloga.Controls.Add(this.dgwUloge);
            this.gbUloga.Controls.Add(this.btnKreirajUlogu);
            this.gbUloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUloga.ForeColor = System.Drawing.Color.Gray;
            this.gbUloga.Location = new System.Drawing.Point(390, 12);
            this.gbUloga.Name = "gbUloga";
            this.gbUloga.Size = new System.Drawing.Size(784, 509);
            this.gbUloga.TabIndex = 1;
            this.gbUloga.TabStop = false;
            this.gbUloga.Text = "Unos uloga";
            // 
            // txtTrenutnaPredstava
            // 
            this.txtTrenutnaPredstava.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrenutnaPredstava.Location = new System.Drawing.Point(149, 86);
            this.txtTrenutnaPredstava.Name = "txtTrenutnaPredstava";
            this.txtTrenutnaPredstava.Size = new System.Drawing.Size(174, 22);
            this.txtTrenutnaPredstava.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Predstava:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Glumac:";
            // 
            // cmbGlumac
            // 
            this.cmbGlumac.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGlumac.FormattingEnabled = true;
            this.cmbGlumac.Location = new System.Drawing.Point(149, 38);
            this.cmbGlumac.Name = "cmbGlumac";
            this.cmbGlumac.Size = new System.Drawing.Size(174, 24);
            this.cmbGlumac.TabIndex = 4;
            // 
            // btnDodajUloge
            // 
            this.btnDodajUloge.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDodajUloge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajUloge.ForeColor = System.Drawing.Color.Black;
            this.btnDodajUloge.Location = new System.Drawing.Point(323, 474);
            this.btnDodajUloge.Name = "btnDodajUloge";
            this.btnDodajUloge.Size = new System.Drawing.Size(110, 29);
            this.btnDodajUloge.TabIndex = 3;
            this.btnDodajUloge.Text = "Dodaj uloge";
            this.btnDodajUloge.UseVisualStyleBackColor = false;
            this.btnDodajUloge.Click += new System.EventHandler(this.btnDodajUloge_Click);
            // 
            // dgwUloge
            // 
            this.dgwUloge.AllowUserToAddRows = false;
            this.dgwUloge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUloge.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwUloge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUloge.Location = new System.Drawing.Point(10, 147);
            this.dgwUloge.Name = "dgwUloge";
            this.dgwUloge.RowHeadersWidth = 51;
            this.dgwUloge.RowTemplate.Height = 24;
            this.dgwUloge.Size = new System.Drawing.Size(761, 321);
            this.dgwUloge.TabIndex = 2;
            // 
            // btnKreirajUlogu
            // 
            this.btnKreirajUlogu.BackColor = System.Drawing.Color.BurlyWood;
            this.btnKreirajUlogu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajUlogu.ForeColor = System.Drawing.Color.Black;
            this.btnKreirajUlogu.Location = new System.Drawing.Point(388, 59);
            this.btnKreirajUlogu.Name = "btnKreirajUlogu";
            this.btnKreirajUlogu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnKreirajUlogu.Size = new System.Drawing.Size(110, 31);
            this.btnKreirajUlogu.TabIndex = 1;
            this.btnKreirajUlogu.Text = "Kreiraj ulogu";
            this.btnKreirajUlogu.UseVisualStyleBackColor = false;
            this.btnKreirajUlogu.Click += new System.EventHandler(this.btnDodajGlumca_Click);
            // 
            // UnosPredstave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1188, 533);
            this.Controls.Add(this.gbUloga);
            this.Controls.Add(this.gbPredstava);
            this.Name = "UnosPredstave";
            this.Text = "Unos predstave";
            this.Load += new System.EventHandler(this.UnosPredstave_Load);
            this.gbPredstava.ResumeLayout(false);
            this.gbPredstava.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZanr)).EndInit();
            this.gbUloga.ResumeLayout(false);
            this.gbUloga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUloge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPredstava;
        private System.Windows.Forms.Button btnUnosPredstave;
        private System.Windows.Forms.DateTimePicker dtpDatumPostavljanja;
        private System.Windows.Forms.TextBox txtNazivPredstave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbUloga;
        private System.Windows.Forms.Button btnKreirajUlogu;
        private System.Windows.Forms.DataGridView dgwUloge;
        private System.Windows.Forms.Button btnDodajUloge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbGlumac;
        private System.Windows.Forms.TextBox txtTrenutnaPredstava;
        private System.Windows.Forms.ComboBox cmbZanr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDodajZanr;
        private System.Windows.Forms.TextBox txtReditelj;
        private System.Windows.Forms.Button btnZanr;
        private System.Windows.Forms.DataGridView dgwZanr;
    }
}
namespace SeminarskiRadPozoriste.FormeRepertoar
{
    partial class UnosRepertoara
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
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnDodajRepertoar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodajIzvodjenja = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum važenja od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum važenja do:";
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(221, 99);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(168, 22);
            this.dtpOd.TabIndex = 2;
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(221, 158);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(168, 22);
            this.dtpDo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Naziv repertoara:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(221, 39);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(168, 22);
            this.txtNaziv.TabIndex = 5;
            // 
            // btnDodajRepertoar
            // 
            this.btnDodajRepertoar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDodajRepertoar.ForeColor = System.Drawing.Color.Black;
            this.btnDodajRepertoar.Location = new System.Drawing.Point(27, 219);
            this.btnDodajRepertoar.Name = "btnDodajRepertoar";
            this.btnDodajRepertoar.Size = new System.Drawing.Size(161, 34);
            this.btnDodajRepertoar.TabIndex = 6;
            this.btnDodajRepertoar.Text = "Dodaj nov repertoar";
            this.btnDodajRepertoar.UseVisualStyleBackColor = false;
            this.btnDodajRepertoar.Click += new System.EventHandler(this.btnDodajRepertoar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodajIzvodjenja);
            this.groupBox1.Controls.Add(this.btnDodajRepertoar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpOd);
            this.groupBox1.Controls.Add(this.dtpDo);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 285);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kreiranje reperotara";
            // 
            // btnDodajIzvodjenja
            // 
            this.btnDodajIzvodjenja.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDodajIzvodjenja.ForeColor = System.Drawing.Color.Black;
            this.btnDodajIzvodjenja.Location = new System.Drawing.Point(228, 219);
            this.btnDodajIzvodjenja.Name = "btnDodajIzvodjenja";
            this.btnDodajIzvodjenja.Size = new System.Drawing.Size(161, 34);
            this.btnDodajIzvodjenja.TabIndex = 7;
            this.btnDodajIzvodjenja.Text = "Dodaj izvodjenja";
            this.btnDodajIzvodjenja.UseVisualStyleBackColor = false;
            this.btnDodajIzvodjenja.Click += new System.EventHandler(this.btnDodajIzvodjenja_Click);
            // 
            // UnosRepertoara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(456, 312);
            this.Controls.Add(this.groupBox1);
            this.Name = "UnosRepertoara";
            this.Text = "Unos repertoara";
            this.Load += new System.EventHandler(this.UnosRepertoara_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnDodajRepertoar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodajIzvodjenja;
    }
}
namespace SeminarskiRadPozoriste.FormaIzvodjenje
{
    partial class DodajIzvodjenje
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
            this.cmbPredstava = new System.Windows.Forms.ComboBox();
            this.dgwIzvodjenja = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajIzvodjenje = new System.Windows.Forms.Button();
            this.btnSacuvajIzvodjenja = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIzvodjenja)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPredstava
            // 
            this.cmbPredstava.FormattingEnabled = true;
            this.cmbPredstava.Location = new System.Drawing.Point(251, 35);
            this.cmbPredstava.Name = "cmbPredstava";
            this.cmbPredstava.Size = new System.Drawing.Size(250, 24);
            this.cmbPredstava.TabIndex = 1;
            // 
            // dgwIzvodjenja
            // 
            this.dgwIzvodjenja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwIzvodjenja.BackgroundColor = System.Drawing.Color.White;
            this.dgwIzvodjenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIzvodjenja.Location = new System.Drawing.Point(40, 196);
            this.dgwIzvodjenja.Name = "dgwIzvodjenja";
            this.dgwIzvodjenja.RowHeadersWidth = 51;
            this.dgwIzvodjenja.RowTemplate.Height = 24;
            this.dgwIzvodjenja.Size = new System.Drawing.Size(721, 242);
            this.dgwIzvodjenja.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Izaberite predstavu:";
            // 
            // btnDodajIzvodjenje
            // 
            this.btnDodajIzvodjenje.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDodajIzvodjenje.Location = new System.Drawing.Point(591, 35);
            this.btnDodajIzvodjenje.Name = "btnDodajIzvodjenje";
            this.btnDodajIzvodjenje.Size = new System.Drawing.Size(170, 48);
            this.btnDodajIzvodjenje.TabIndex = 5;
            this.btnDodajIzvodjenje.Text = "Dodaj izvođenje";
            this.btnDodajIzvodjenje.UseVisualStyleBackColor = false;
            this.btnDodajIzvodjenje.Click += new System.EventHandler(this.btnDodajIzvodjenje_Click);
            // 
            // btnSacuvajIzvodjenja
            // 
            this.btnSacuvajIzvodjenja.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSacuvajIzvodjenja.Location = new System.Drawing.Point(591, 120);
            this.btnSacuvajIzvodjenja.Name = "btnSacuvajIzvodjenja";
            this.btnSacuvajIzvodjenja.Size = new System.Drawing.Size(170, 49);
            this.btnSacuvajIzvodjenja.TabIndex = 6;
            this.btnSacuvajIzvodjenja.Text = "Sačuvaj sva izvođenja";
            this.btnSacuvajIzvodjenja.UseVisualStyleBackColor = false;
            this.btnSacuvajIzvodjenja.Click += new System.EventHandler(this.btnSacuvajIzvodjenja_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Izaberite dan:";
            // 
            // cmbDan
            // 
            this.cmbDan.FormattingEnabled = true;
            this.cmbDan.Location = new System.Drawing.Point(251, 88);
            this.cmbDan.Name = "cmbDan";
            this.cmbDan.Size = new System.Drawing.Size(250, 24);
            this.cmbDan.TabIndex = 7;
            // 
            // DodajIzvodjenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDan);
            this.Controls.Add(this.btnSacuvajIzvodjenja);
            this.Controls.Add(this.btnDodajIzvodjenje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgwIzvodjenja);
            this.Controls.Add(this.cmbPredstava);
            this.Name = "DodajIzvodjenje";
            this.Text = "Dodaj izvodjenje";
            this.Load += new System.EventHandler(this.DodajIzvodjenje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwIzvodjenja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbPredstava;
        private System.Windows.Forms.DataGridView dgwIzvodjenja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajIzvodjenje;
        private System.Windows.Forms.Button btnSacuvajIzvodjenja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDan;
    }
}
namespace SeminarskiRadPozoriste.FormeRepertoar
{
    partial class PretragaRepertoaraDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwIzvodjenja = new System.Windows.Forms.DataGridView();
            this.txtDatumDo = new System.Windows.Forms.TextBox();
            this.txtDatumOd = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIzvodjenja)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwIzvodjenja);
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(375, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 309);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista izvodjenja";
            // 
            // dgwIzvodjenja
            // 
            this.dgwIzvodjenja.AllowUserToAddRows = false;
            this.dgwIzvodjenja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwIzvodjenja.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwIzvodjenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIzvodjenja.Location = new System.Drawing.Point(6, 22);
            this.dgwIzvodjenja.Name = "dgwIzvodjenja";
            this.dgwIzvodjenja.RowHeadersWidth = 51;
            this.dgwIzvodjenja.RowTemplate.Height = 24;
            this.dgwIzvodjenja.Size = new System.Drawing.Size(556, 281);
            this.dgwIzvodjenja.TabIndex = 0;
            // 
            // txtDatumDo
            // 
            this.txtDatumDo.Location = new System.Drawing.Point(192, 150);
            this.txtDatumDo.Name = "txtDatumDo";
            this.txtDatumDo.Size = new System.Drawing.Size(168, 22);
            this.txtDatumDo.TabIndex = 15;
            // 
            // txtDatumOd
            // 
            this.txtDatumOd.Location = new System.Drawing.Point(192, 93);
            this.txtDatumOd.Name = "txtDatumOd";
            this.txtDatumOd.Size = new System.Drawing.Size(168, 22);
            this.txtDatumOd.TabIndex = 14;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(192, 36);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(168, 22);
            this.txtNaziv.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Datum do:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Datum od:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Naziv repertoara:";
            // 
            // PretragaRepertoaraDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(955, 335);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDatumDo);
            this.Controls.Add(this.txtDatumOd);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PretragaRepertoaraDialog";
            this.Text = "PretragaRepertoaraDialog";
            this.Load += new System.EventHandler(this.PretragaRepertoaraDialog_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwIzvodjenja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgwIzvodjenja;
        private System.Windows.Forms.TextBox txtDatumDo;
        private System.Windows.Forms.TextBox txtDatumOd;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
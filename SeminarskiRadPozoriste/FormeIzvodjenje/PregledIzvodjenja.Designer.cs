namespace SeminarskiRadPozoriste.FormaIzvodjenje
{
    partial class PregledIzvodjenja
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
            this.dgwIzvodjenja = new System.Windows.Forms.DataGridView();
            this.cmbRepertoar = new System.Windows.Forms.ComboBox();
            this.cmbPredstava = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIzvodjenja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwIzvodjenja
            // 
            this.dgwIzvodjenja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwIzvodjenja.BackgroundColor = System.Drawing.Color.White;
            this.dgwIzvodjenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIzvodjenja.Location = new System.Drawing.Point(44, 127);
            this.dgwIzvodjenja.Name = "dgwIzvodjenja";
            this.dgwIzvodjenja.RowHeadersWidth = 51;
            this.dgwIzvodjenja.RowTemplate.Height = 24;
            this.dgwIzvodjenja.Size = new System.Drawing.Size(713, 304);
            this.dgwIzvodjenja.TabIndex = 9;
            // 
            // cmbRepertoar
            // 
            this.cmbRepertoar.FormattingEnabled = true;
            this.cmbRepertoar.Location = new System.Drawing.Point(401, 69);
            this.cmbRepertoar.Name = "cmbRepertoar";
            this.cmbRepertoar.Size = new System.Drawing.Size(206, 24);
            this.cmbRepertoar.TabIndex = 8;
            this.cmbRepertoar.SelectedIndexChanged += new System.EventHandler(this.cmbRepertoar_SelectedIndexChanged);
            // 
            // cmbPredstava
            // 
            this.cmbPredstava.FormattingEnabled = true;
            this.cmbPredstava.Location = new System.Drawing.Point(401, 19);
            this.cmbPredstava.Name = "cmbPredstava";
            this.cmbPredstava.Size = new System.Drawing.Size(206, 24);
            this.cmbPredstava.TabIndex = 7;
            this.cmbPredstava.SelectedIndexChanged += new System.EventHandler(this.cmbPredstava_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pregledaj izvodjenja za predstavu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pregledaj izvodjenja za repertoar:";
            // 
            // PregledIzvodjenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwIzvodjenja);
            this.Controls.Add(this.cmbRepertoar);
            this.Controls.Add(this.cmbPredstava);
            this.Name = "PregledIzvodjenja";
            this.Text = "PregledIzvodjenja";
            this.Load += new System.EventHandler(this.PregledIzvodjenja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwIzvodjenja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwIzvodjenja;
        private System.Windows.Forms.ComboBox cmbRepertoar;
        private System.Windows.Forms.ComboBox cmbPredstava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
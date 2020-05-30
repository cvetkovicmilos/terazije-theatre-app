namespace SeminarskiRadPozoriste.FormeRepertoar
{
    partial class BrisanjeRepertoara
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
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.dgwRepertoar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRepertoar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.BackColor = System.Drawing.Color.BurlyWood;
            this.btnIzaberi.Location = new System.Drawing.Point(333, 395);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(134, 33);
            this.btnIzaberi.TabIndex = 14;
            this.btnIzaberi.Text = "Izaberi repertoar";
            this.btnIzaberi.UseVisualStyleBackColor = false;
            this.btnIzaberi.Click += new System.EventHandler(this.btnIzaberi_Click);
            // 
            // dgwRepertoar
            // 
            this.dgwRepertoar.AllowUserToAddRows = false;
            this.dgwRepertoar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwRepertoar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwRepertoar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRepertoar.Location = new System.Drawing.Point(11, 69);
            this.dgwRepertoar.Name = "dgwRepertoar";
            this.dgwRepertoar.RowHeadersWidth = 51;
            this.dgwRepertoar.RowTemplate.Height = 24;
            this.dgwRepertoar.Size = new System.Drawing.Size(779, 308);
            this.dgwRepertoar.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(220, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Molimo izaberite repertoar koji želite da obrišete!";
            // 
            // BrisanjeRepertoara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.dgwRepertoar);
            this.Controls.Add(this.label1);
            this.Name = "BrisanjeRepertoara";
            this.Text = "BrisanjeRepertoara";
            this.Load += new System.EventHandler(this.BrisanjeRepertoara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRepertoar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzaberi;
        private System.Windows.Forms.DataGridView dgwRepertoar;
        private System.Windows.Forms.Label label1;
    }
}
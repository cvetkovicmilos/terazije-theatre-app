namespace SeminarskiRadPozoriste.FormeGlumac
{
    partial class IzmenaGlumca
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
            this.dgwGlumci = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGlumci)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.BackColor = System.Drawing.Color.BurlyWood;
            this.btnIzaberi.Location = new System.Drawing.Point(332, 395);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(134, 33);
            this.btnIzaberi.TabIndex = 5;
            this.btnIzaberi.Text = "Izaberi glumca";
            this.btnIzaberi.UseVisualStyleBackColor = false;
            this.btnIzaberi.Click += new System.EventHandler(this.btnIzaberi_Click);
            // 
            // dgwGlumci
            // 
            this.dgwGlumci.AllowUserToAddRows = false;
            this.dgwGlumci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwGlumci.BackgroundColor = System.Drawing.Color.White;
            this.dgwGlumci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGlumci.Location = new System.Drawing.Point(11, 69);
            this.dgwGlumci.Name = "dgwGlumci";
            this.dgwGlumci.RowHeadersWidth = 51;
            this.dgwGlumci.RowTemplate.Height = 24;
            this.dgwGlumci.Size = new System.Drawing.Size(779, 308);
            this.dgwGlumci.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(221, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Molimo izaberite glumca kog želite da izmenite!";
            // 
            // IzmenaGlumca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.dgwGlumci);
            this.Controls.Add(this.label1);
            this.Name = "IzmenaGlumca";
            this.Text = "Izmena glumca";
            this.Load += new System.EventHandler(this.IzmenaGlumca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGlumci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzaberi;
        private System.Windows.Forms.DataGridView dgwGlumci;
        private System.Windows.Forms.Label label1;
    }
}
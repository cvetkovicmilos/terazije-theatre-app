namespace SeminarskiRadPozoriste.FormeRepertoar
{
    partial class PretragaRepertoara
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
            this.dgwRepertoari = new System.Windows.Forms.DataGridView();
            this.txtPojam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRepertoari)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.BackColor = System.Drawing.Color.BurlyWood;
            this.btnIzaberi.Location = new System.Drawing.Point(646, 20);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(142, 33);
            this.btnIzaberi.TabIndex = 16;
            this.btnIzaberi.Text = "Izaberi repertoar";
            this.btnIzaberi.UseVisualStyleBackColor = false;
            this.btnIzaberi.Click += new System.EventHandler(this.btnIzaberi_Click);
            // 
            // dgwRepertoari
            // 
            this.dgwRepertoari.AllowUserToAddRows = false;
            this.dgwRepertoari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwRepertoari.BackgroundColor = System.Drawing.Color.White;
            this.dgwRepertoari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRepertoari.Location = new System.Drawing.Point(11, 77);
            this.dgwRepertoari.Name = "dgwRepertoari";
            this.dgwRepertoari.RowHeadersWidth = 51;
            this.dgwRepertoari.RowTemplate.Height = 24;
            this.dgwRepertoari.Size = new System.Drawing.Size(779, 353);
            this.dgwRepertoari.TabIndex = 15;
            // 
            // txtPojam
            // 
            this.txtPojam.AcceptsTab = true;
            this.txtPojam.Location = new System.Drawing.Point(306, 25);
            this.txtPojam.Name = "txtPojam";
            this.txtPojam.Size = new System.Drawing.Size(188, 22);
            this.txtPojam.TabIndex = 14;
            this.txtPojam.TextChanged += new System.EventHandler(this.txtPojam_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Molimo unesite pojam pretrage:";
            // 
            // PretragaRepertoara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.dgwRepertoari);
            this.Controls.Add(this.txtPojam);
            this.Controls.Add(this.label1);
            this.Name = "PretragaRepertoara";
            this.Text = "PretragaRepertoara";
            this.Load += new System.EventHandler(this.PretragaRepertoara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRepertoari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzaberi;
        private System.Windows.Forms.DataGridView dgwRepertoari;
        private System.Windows.Forms.TextBox txtPojam;
        private System.Windows.Forms.Label label1;
    }
}
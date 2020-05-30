namespace SeminarskiRadPozoriste.FormePredstava
{
    partial class PretragaPredstava
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
            this.dgwPredstave = new System.Windows.Forms.DataGridView();
            this.txtPojam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzaberi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPredstave)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwPredstave
            // 
            this.dgwPredstave.AllowUserToAddRows = false;
            this.dgwPredstave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPredstave.BackgroundColor = System.Drawing.Color.White;
            this.dgwPredstave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPredstave.Location = new System.Drawing.Point(11, 75);
            this.dgwPredstave.Name = "dgwPredstave";
            this.dgwPredstave.RowHeadersWidth = 51;
            this.dgwPredstave.RowTemplate.Height = 24;
            this.dgwPredstave.Size = new System.Drawing.Size(779, 353);
            this.dgwPredstave.TabIndex = 11;
            // 
            // txtPojam
            // 
            this.txtPojam.AcceptsTab = true;
            this.txtPojam.Location = new System.Drawing.Point(321, 23);
            this.txtPojam.Name = "txtPojam";
            this.txtPojam.Size = new System.Drawing.Size(188, 22);
            this.txtPojam.TabIndex = 10;
            this.txtPojam.TextChanged += new System.EventHandler(this.txtPojam_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Molimo unesite pojam pretrage:";
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.BackColor = System.Drawing.Color.BurlyWood;
            this.btnIzaberi.Location = new System.Drawing.Point(646, 18);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(142, 33);
            this.btnIzaberi.TabIndex = 12;
            this.btnIzaberi.Text = "Izaberi predstavu";
            this.btnIzaberi.UseVisualStyleBackColor = false;
            this.btnIzaberi.Click += new System.EventHandler(this.btnIzaberi_Click);
            // 
            // PretragaPredstava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.dgwPredstave);
            this.Controls.Add(this.txtPojam);
            this.Controls.Add(this.label1);
            this.Name = "PretragaPredstava";
            this.Text = "Pretraga predstava";
            this.Load += new System.EventHandler(this.PretragaPredstava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPredstave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPredstave;
        private System.Windows.Forms.TextBox txtPojam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzaberi;
    }
}
namespace SeminarskiRadPozoriste.FormeZanr
{
    partial class PregledZanrova
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
            this.dgwPregledZanrova = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPregledZanrova)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwPregledZanrova);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled svih žanrova";
            // 
            // dgwPregledZanrova
            // 
            this.dgwPregledZanrova.AllowUserToAddRows = false;
            this.dgwPregledZanrova.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPregledZanrova.BackgroundColor = System.Drawing.Color.White;
            this.dgwPregledZanrova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPregledZanrova.Location = new System.Drawing.Point(6, 42);
            this.dgwPregledZanrova.Name = "dgwPregledZanrova";
            this.dgwPregledZanrova.RowHeadersWidth = 51;
            this.dgwPregledZanrova.RowTemplate.Height = 24;
            this.dgwPregledZanrova.Size = new System.Drawing.Size(659, 378);
            this.dgwPregledZanrova.TabIndex = 0;
            // 
            // PregledZanrova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "PregledZanrova";
            this.Text = "Pregled zanrova";
            this.Load += new System.EventHandler(this.PregledZanrova_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPregledZanrova)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgwPregledZanrova;
    }
}
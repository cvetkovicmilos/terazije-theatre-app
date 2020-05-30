namespace SeminarskiRadPozoriste.FormeZanr
{
    partial class UnosZanra
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
            this.txtZanr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajZanr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtZanr
            // 
            this.txtZanr.Location = new System.Drawing.Point(169, 40);
            this.txtZanr.Name = "txtZanr";
            this.txtZanr.Size = new System.Drawing.Size(144, 22);
            this.txtZanr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv žanra:";
            // 
            // btnDodajZanr
            // 
            this.btnDodajZanr.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDodajZanr.Location = new System.Drawing.Point(119, 104);
            this.btnDodajZanr.Name = "btnDodajZanr";
            this.btnDodajZanr.Size = new System.Drawing.Size(113, 31);
            this.btnDodajZanr.TabIndex = 2;
            this.btnDodajZanr.Text = "Dodaj žanr";
            this.btnDodajZanr.UseVisualStyleBackColor = false;
            this.btnDodajZanr.Click += new System.EventHandler(this.btnDodajZanr_Click);
            // 
            // UnosZanra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(351, 177);
            this.Controls.Add(this.btnDodajZanr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZanr);
            this.Name = "UnosZanra";
            this.Text = "Unos zanra";
            this.Load += new System.EventHandler(this.UnosZanra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtZanr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajZanr;
    }
}
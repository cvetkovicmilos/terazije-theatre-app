namespace SeminarskiRadPozoriste.FormePredstava
{
    partial class UnosPredstaveUlogaDialog
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
            this.lblGlumac = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.btnDodajUlogu = new System.Windows.Forms.Button();
            this.lblPredstava = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGlumac
            // 
            this.lblGlumac.AutoSize = true;
            this.lblGlumac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlumac.ForeColor = System.Drawing.Color.White;
            this.lblGlumac.Location = new System.Drawing.Point(25, 27);
            this.lblGlumac.Name = "lblGlumac";
            this.lblGlumac.Size = new System.Drawing.Size(59, 20);
            this.lblGlumac.TabIndex = 0;
            this.lblGlumac.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv uloge:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip uloge:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(169, 123);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(190, 22);
            this.txtNaziv.TabIndex = 3;
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(169, 173);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(190, 22);
            this.txtTip.TabIndex = 4;
            // 
            // btnDodajUlogu
            // 
            this.btnDodajUlogu.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDodajUlogu.Location = new System.Drawing.Point(141, 221);
            this.btnDodajUlogu.Name = "btnDodajUlogu";
            this.btnDodajUlogu.Size = new System.Drawing.Size(94, 28);
            this.btnDodajUlogu.TabIndex = 5;
            this.btnDodajUlogu.Text = "Dodaj ulogu";
            this.btnDodajUlogu.UseVisualStyleBackColor = false;
            this.btnDodajUlogu.Click += new System.EventHandler(this.btnDodajUlogu_Click);
            // 
            // lblPredstava
            // 
            this.lblPredstava.AutoSize = true;
            this.lblPredstava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredstava.ForeColor = System.Drawing.Color.White;
            this.lblPredstava.Location = new System.Drawing.Point(25, 67);
            this.lblPredstava.Name = "lblPredstava";
            this.lblPredstava.Size = new System.Drawing.Size(59, 20);
            this.lblPredstava.TabIndex = 6;
            this.lblPredstava.Text = "label1";
            // 
            // UnosPredstaveUlogaDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(386, 283);
            this.Controls.Add(this.lblPredstava);
            this.Controls.Add(this.btnDodajUlogu);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGlumac);
            this.Name = "UnosPredstaveUlogaDialog";
            this.Text = "UnosPredstaveUlogaDialog";
            this.Load += new System.EventHandler(this.UnosPredstaveUlogaDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGlumac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Button btnDodajUlogu;
        private System.Windows.Forms.Label lblPredstava;
    }
}
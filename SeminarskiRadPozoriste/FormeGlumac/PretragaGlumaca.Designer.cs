namespace SeminarskiRadPozoriste.FormeGlumac
{
    partial class PretragaGlumaca
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPojam = new System.Windows.Forms.TextBox();
            this.dgwGlumci = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGlumci)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Molimo unesite pojam pretrage:";
            // 
            // txtPojam
            // 
            this.txtPojam.AcceptsTab = true;
            this.txtPojam.Location = new System.Drawing.Point(328, 33);
            this.txtPojam.Name = "txtPojam";
            this.txtPojam.Size = new System.Drawing.Size(188, 22);
            this.txtPojam.TabIndex = 1;
            this.txtPojam.TextChanged += new System.EventHandler(this.txtPojam_TextChanged);
            // 
            // dgwGlumci
            // 
            this.dgwGlumci.AllowUserToAddRows = false;
            this.dgwGlumci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwGlumci.BackgroundColor = System.Drawing.Color.White;
            this.dgwGlumci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGlumci.Location = new System.Drawing.Point(9, 85);
            this.dgwGlumci.Name = "dgwGlumci";
            this.dgwGlumci.RowHeadersWidth = 51;
            this.dgwGlumci.RowTemplate.Height = 24;
            this.dgwGlumci.Size = new System.Drawing.Size(779, 353);
            this.dgwGlumci.TabIndex = 8;
            // 
            // PretragaGlumaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwGlumci);
            this.Controls.Add(this.txtPojam);
            this.Controls.Add(this.label1);
            this.Name = "PretragaGlumaca";
            this.Text = "PretragaGlumaca";
            this.Load += new System.EventHandler(this.PretragaGlumaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGlumci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPojam;
        private System.Windows.Forms.DataGridView dgwGlumci;
    }
}
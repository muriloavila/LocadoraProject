namespace LocadoraProject
{
    partial class frmItemDesc
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
            this.pcbCapa = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbCapa
            // 
            this.pcbCapa.Location = new System.Drawing.Point(0, 0);
            this.pcbCapa.Name = "pcbCapa";
            this.pcbCapa.Size = new System.Drawing.Size(100, 131);
            this.pcbCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCapa.TabIndex = 0;
            this.pcbCapa.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(196, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ano";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(196, 31);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(35, 13);
            this.lblAno.TabIndex = 4;
            this.lblAno.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Genero";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(196, 53);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(35, 13);
            this.lblGenero.TabIndex = 6;
            this.lblGenero.Text = "label6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmItemDesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 177);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbCapa);
            this.Name = "frmItemDesc";
            this.Text = "itemDesc";
            this.Load += new System.EventHandler(this.itemDesc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbCapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
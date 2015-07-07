namespace LocadoraProject
{
    partial class Form1
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
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.rdbCliente = new System.Windows.Forms.RadioButton();
            this.rdbAdm = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(85, 149);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 0;
            this.txtSenha.Text = "anjonegro";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(85, 104);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.Text = "muriloavila";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(85, 226);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdbCliente
            // 
            this.rdbCliente.AutoSize = true;
            this.rdbCliente.Location = new System.Drawing.Point(187, 186);
            this.rdbCliente.Name = "rdbCliente";
            this.rdbCliente.Size = new System.Drawing.Size(57, 17);
            this.rdbCliente.TabIndex = 3;
            this.rdbCliente.TabStop = true;
            this.rdbCliente.Text = "Cliente";
            this.rdbCliente.UseVisualStyleBackColor = true;
            // 
            // rdbAdm
            // 
            this.rdbAdm.AutoSize = true;
            this.rdbAdm.Location = new System.Drawing.Point(12, 186);
            this.rdbAdm.Name = "rdbAdm";
            this.rdbAdm.Size = new System.Drawing.Size(88, 17);
            this.rdbAdm.TabIndex = 4;
            this.rdbAdm.TabStop = true;
            this.rdbAdm.Text = "Administrador";
            this.rdbAdm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rdbAdm);
            this.Controls.Add(this.rdbCliente);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtSenha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton rdbCliente;
        private System.Windows.Forms.RadioButton rdbAdm;
    }
}


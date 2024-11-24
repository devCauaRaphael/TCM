namespace BackEndTcm
{
    partial class frmMenu
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
            this.btnCadastroCli = new System.Windows.Forms.Button();
            this.btnConsultaCli = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUtilitarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTROS E CONSULTAS";
            // 
            // btnCadastroCli
            // 
            this.btnCadastroCli.Location = new System.Drawing.Point(316, 123);
            this.btnCadastroCli.Name = "btnCadastroCli";
            this.btnCadastroCli.Size = new System.Drawing.Size(108, 38);
            this.btnCadastroCli.TabIndex = 1;
            this.btnCadastroCli.Text = "CADASTRAR";
            this.btnCadastroCli.UseVisualStyleBackColor = true;
            this.btnCadastroCli.Click += new System.EventHandler(this.btnCadastroCli_Click);
            // 
            // btnConsultaCli
            // 
            this.btnConsultaCli.Location = new System.Drawing.Point(316, 214);
            this.btnConsultaCli.Name = "btnConsultaCli";
            this.btnConsultaCli.Size = new System.Drawing.Size(108, 38);
            this.btnConsultaCli.TabIndex = 2;
            this.btnConsultaCli.Text = "CONSULTAR";
            this.btnConsultaCli.UseVisualStyleBackColor = true;
            this.btnConsultaCli.Click += new System.EventHandler(this.btnConsultaCli_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(327, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "CLIENTE";
            // 
            // btnUtilitarios
            // 
            this.btnUtilitarios.Location = new System.Drawing.Point(316, 297);
            this.btnUtilitarios.Name = "btnUtilitarios";
            this.btnUtilitarios.Size = new System.Drawing.Size(108, 38);
            this.btnUtilitarios.TabIndex = 3;
            this.btnUtilitarios.Text = "UTILITÁRIOS";
            this.btnUtilitarios.UseVisualStyleBackColor = true;
            this.btnUtilitarios.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUtilitarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultaCli);
            this.Controls.Add(this.btnCadastroCli);
            this.Controls.Add(this.label1);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastroCli;
        private System.Windows.Forms.Button btnConsultaCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUtilitarios;
    }
}
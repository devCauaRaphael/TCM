namespace BackEndTcm
{
    partial class frmUtilitarios
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnFibonacci = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            this.btnFutebol = new System.Windows.Forms.Button();
            this.btnFatorial = new System.Windows.Forms.Button();
            this.btnMaiorMenor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "UTILITÁRIOS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnFibonacci
            // 
            this.btnFibonacci.ForeColor = System.Drawing.Color.Black;
            this.btnFibonacci.Location = new System.Drawing.Point(301, 79);
            this.btnFibonacci.Name = "btnFibonacci";
            this.btnFibonacci.Size = new System.Drawing.Size(108, 38);
            this.btnFibonacci.TabIndex = 2;
            this.btnFibonacci.Text = "FIBONACCI";
            this.btnFibonacci.UseVisualStyleBackColor = true;
            this.btnFibonacci.Click += new System.EventHandler(this.btnFibonacci_Click);
            // 
            // btnMes
            // 
            this.btnMes.ForeColor = System.Drawing.Color.Black;
            this.btnMes.Location = new System.Drawing.Point(301, 148);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(108, 38);
            this.btnMes.TabIndex = 3;
            this.btnMes.Text = "MÊS";
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // btnFutebol
            // 
            this.btnFutebol.ForeColor = System.Drawing.Color.Black;
            this.btnFutebol.Location = new System.Drawing.Point(301, 217);
            this.btnFutebol.Name = "btnFutebol";
            this.btnFutebol.Size = new System.Drawing.Size(108, 38);
            this.btnFutebol.TabIndex = 4;
            this.btnFutebol.Text = "FUTEBOL";
            this.btnFutebol.UseVisualStyleBackColor = true;
            this.btnFutebol.Click += new System.EventHandler(this.btnFutebol_Click);
            // 
            // btnFatorial
            // 
            this.btnFatorial.ForeColor = System.Drawing.Color.Black;
            this.btnFatorial.Location = new System.Drawing.Point(301, 285);
            this.btnFatorial.Name = "btnFatorial";
            this.btnFatorial.Size = new System.Drawing.Size(108, 38);
            this.btnFatorial.TabIndex = 5;
            this.btnFatorial.Text = "FATORIAL";
            this.btnFatorial.UseVisualStyleBackColor = true;
            this.btnFatorial.Click += new System.EventHandler(this.btnFatorial_Click);
            // 
            // btnMaiorMenor
            // 
            this.btnMaiorMenor.ForeColor = System.Drawing.Color.Black;
            this.btnMaiorMenor.Location = new System.Drawing.Point(291, 347);
            this.btnMaiorMenor.Name = "btnMaiorMenor";
            this.btnMaiorMenor.Size = new System.Drawing.Size(131, 38);
            this.btnMaiorMenor.TabIndex = 6;
            this.btnMaiorMenor.Text = "MENOR E MAIOR";
            this.btnMaiorMenor.UseVisualStyleBackColor = true;
            this.btnMaiorMenor.Click += new System.EventHandler(this.btnMaiorMenor_Click);
            // 
            // frmUtilitarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMaiorMenor);
            this.Controls.Add(this.btnFatorial);
            this.Controls.Add(this.btnFutebol);
            this.Controls.Add(this.btnMes);
            this.Controls.Add(this.btnFibonacci);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmUtilitarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUtilitarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFibonacci;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Button btnFutebol;
        private System.Windows.Forms.Button btnFatorial;
        private System.Windows.Forms.Button btnMaiorMenor;
    }
}
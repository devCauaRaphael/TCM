﻿namespace BackEndTcm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aTUALIZARCADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTRARPRODUTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CONSULTARCADASTRO = new System.Windows.Forms.ToolStripMenuItem();
            this.uTILITÁRIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fIBONACCIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fATORIALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mENOREMAIORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mÊSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fUTEBOLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timeEfeitoDigitacao = new System.Windows.Forms.Timer(this.components);
            this.btnVoltar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Navy;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESToolStripMenuItem,
            this.pRODUTOSToolStripMenuItem,
            this.uTILITÁRIOSToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.cLIENTESToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2272, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cLIENTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTRARToolStripMenuItem,
            this.aTUALIZARCADASTROToolStripMenuItem,
            this.cONSULTARToolStripMenuItem});
            this.cLIENTESToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLIENTESToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(127, 33);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            this.cLIENTESToolStripMenuItem.Click += new System.EventHandler(this.cLIENTESToolStripMenuItem_Click);
            // 
            // cADASTRARToolStripMenuItem
            // 
            this.cADASTRARToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cADASTRARToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cADASTRARToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cADASTRARToolStripMenuItem.Image")));
            this.cADASTRARToolStripMenuItem.Name = "cADASTRARToolStripMenuItem";
            this.cADASTRARToolStripMenuItem.Size = new System.Drawing.Size(352, 34);
            this.cADASTRARToolStripMenuItem.Text = "CADASTRAR";
            this.cADASTRARToolStripMenuItem.Click += new System.EventHandler(this.cADASTRARToolStripMenuItem_Click);
            // 
            // aTUALIZARCADASTROToolStripMenuItem
            // 
            this.aTUALIZARCADASTROToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.aTUALIZARCADASTROToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aTUALIZARCADASTROToolStripMenuItem.Image")));
            this.aTUALIZARCADASTROToolStripMenuItem.Name = "aTUALIZARCADASTROToolStripMenuItem";
            this.aTUALIZARCADASTROToolStripMenuItem.Size = new System.Drawing.Size(352, 34);
            this.aTUALIZARCADASTROToolStripMenuItem.Text = "EDITAR CADASTRO";
            this.aTUALIZARCADASTROToolStripMenuItem.Click += new System.EventHandler(this.aTUALIZARCADASTROToolStripMenuItem_Click);
            // 
            // cONSULTARToolStripMenuItem
            // 
            this.cONSULTARToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cONSULTARToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cONSULTARToolStripMenuItem.Image")));
            this.cONSULTARToolStripMenuItem.Name = "cONSULTARToolStripMenuItem";
            this.cONSULTARToolStripMenuItem.Size = new System.Drawing.Size(352, 34);
            this.cONSULTARToolStripMenuItem.Text = "CONSULTAR CADASTRO";
            this.cONSULTARToolStripMenuItem.Click += new System.EventHandler(this.cONSULTARToolStripMenuItem_Click);
            // 
            // pRODUTOSToolStripMenuItem
            // 
            this.pRODUTOSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pRODUTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTRARPRODUTOSToolStripMenuItem,
            this.CONSULTARCADASTRO});
            this.pRODUTOSToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pRODUTOSToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.pRODUTOSToolStripMenuItem.Name = "pRODUTOSToolStripMenuItem";
            this.pRODUTOSToolStripMenuItem.Size = new System.Drawing.Size(151, 33);
            this.pRODUTOSToolStripMenuItem.Text = "PRODUTOS";
            // 
            // cADASTRARPRODUTOSToolStripMenuItem
            // 
            this.cADASTRARPRODUTOSToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cADASTRARPRODUTOSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cADASTRARPRODUTOSToolStripMenuItem.Image")));
            this.cADASTRARPRODUTOSToolStripMenuItem.Name = "cADASTRARPRODUTOSToolStripMenuItem";
            this.cADASTRARPRODUTOSToolStripMenuItem.Size = new System.Drawing.Size(360, 34);
            this.cADASTRARPRODUTOSToolStripMenuItem.Text = "CADASTRAR PRODUTOS";
            this.cADASTRARPRODUTOSToolStripMenuItem.Click += new System.EventHandler(this.cADASTRARPRODUTOSToolStripMenuItem_Click);
            // 
            // CONSULTARCADASTRO
            // 
            this.CONSULTARCADASTRO.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CONSULTARCADASTRO.Image = ((System.Drawing.Image)(resources.GetObject("CONSULTARCADASTRO.Image")));
            this.CONSULTARCADASTRO.Name = "CONSULTARCADASTRO";
            this.CONSULTARCADASTRO.Size = new System.Drawing.Size(360, 34);
            this.CONSULTARCADASTRO.Text = "CONSULTAR PRODUTO";
            this.CONSULTARCADASTRO.Click += new System.EventHandler(this.CONSULTARCADASTRO_Click);
            // 
            // uTILITÁRIOSToolStripMenuItem
            // 
            this.uTILITÁRIOSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uTILITÁRIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIBONACCIToolStripMenuItem,
            this.fATORIALToolStripMenuItem,
            this.mENOREMAIORToolStripMenuItem,
            this.mÊSToolStripMenuItem,
            this.fUTEBOLToolStripMenuItem});
            this.uTILITÁRIOSToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uTILITÁRIOSToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.uTILITÁRIOSToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.uTILITÁRIOSToolStripMenuItem.Name = "uTILITÁRIOSToolStripMenuItem";
            this.uTILITÁRIOSToolStripMenuItem.Size = new System.Drawing.Size(166, 33);
            this.uTILITÁRIOSToolStripMenuItem.Text = "UTILITÁRIOS";
            this.uTILITÁRIOSToolStripMenuItem.Click += new System.EventHandler(this.uTILITÁRIOSToolStripMenuItem_Click);
            // 
            // fIBONACCIToolStripMenuItem
            // 
            this.fIBONACCIToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.fIBONACCIToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fIBONACCIToolStripMenuItem.Image")));
            this.fIBONACCIToolStripMenuItem.Name = "fIBONACCIToolStripMenuItem";
            this.fIBONACCIToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.fIBONACCIToolStripMenuItem.Text = "FIBONACCI";
            this.fIBONACCIToolStripMenuItem.Click += new System.EventHandler(this.fIBONACCIToolStripMenuItem_Click);
            // 
            // fATORIALToolStripMenuItem
            // 
            this.fATORIALToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.fATORIALToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fATORIALToolStripMenuItem.Image")));
            this.fATORIALToolStripMenuItem.Name = "fATORIALToolStripMenuItem";
            this.fATORIALToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.fATORIALToolStripMenuItem.Text = "FATORIAL";
            this.fATORIALToolStripMenuItem.Click += new System.EventHandler(this.fATORIALToolStripMenuItem_Click);
            // 
            // mENOREMAIORToolStripMenuItem
            // 
            this.mENOREMAIORToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.mENOREMAIORToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mENOREMAIORToolStripMenuItem.Image")));
            this.mENOREMAIORToolStripMenuItem.Name = "mENOREMAIORToolStripMenuItem";
            this.mENOREMAIORToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.mENOREMAIORToolStripMenuItem.Text = "MENOR E MAIOR";
            this.mENOREMAIORToolStripMenuItem.Click += new System.EventHandler(this.mENOREMAIORToolStripMenuItem_Click);
            // 
            // mÊSToolStripMenuItem
            // 
            this.mÊSToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.mÊSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mÊSToolStripMenuItem.Image")));
            this.mÊSToolStripMenuItem.Name = "mÊSToolStripMenuItem";
            this.mÊSToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.mÊSToolStripMenuItem.Text = "MÊS";
            this.mÊSToolStripMenuItem.Click += new System.EventHandler(this.mÊSToolStripMenuItem_Click);
            // 
            // fUTEBOLToolStripMenuItem
            // 
            this.fUTEBOLToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.fUTEBOLToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fUTEBOLToolStripMenuItem.Image")));
            this.fUTEBOLToolStripMenuItem.Name = "fUTEBOLToolStripMenuItem";
            this.fUTEBOLToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.fUTEBOLToolStripMenuItem.Text = "FUTEBOL";
            this.fUTEBOLToolStripMenuItem.Click += new System.EventHandler(this.fUTEBOLToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // timeEfeitoDigitacao
            // 
            this.timeEfeitoDigitacao.Enabled = true;
            this.timeEfeitoDigitacao.Tick += new System.EventHandler(this.timeEfeitoDigitacao_Tick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVoltar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(600, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(113, 37);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = global::BackEndTcm.Properties.Resources.Design_sem_nome__9_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2272, 716);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aTUALIZARCADASTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uTILITÁRIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTRARPRODUTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CONSULTARCADASTRO;
        private System.Windows.Forms.ToolStripMenuItem fIBONACCIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fATORIALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mENOREMAIORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mÊSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fUTEBOLToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer timeEfeitoDigitacao;
        private System.Windows.Forms.Button btnVoltar;
    }
}
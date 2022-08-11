namespace CodAlunos
{
    partial class export
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(export));
            this.cmdxml = new System.Windows.Forms.Button();
            this.cboturma = new System.Windows.Forms.ComboBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpexport = new System.Windows.Forms.DateTimePicker();
            this.cmdvolta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdxml
            // 
            this.cmdxml.BackColor = System.Drawing.Color.Silver;
            this.cmdxml.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdxml.Enabled = false;
            this.cmdxml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdxml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdxml.Location = new System.Drawing.Point(115, 149);
            this.cmdxml.Name = "cmdxml";
            this.cmdxml.Size = new System.Drawing.Size(182, 41);
            this.cmdxml.TabIndex = 79;
            this.cmdxml.Text = "Gerar Arquivo XML";
            this.cmdxml.UseVisualStyleBackColor = true;
            this.cmdxml.Click += new System.EventHandler(this.cmdxml_Click);
            // 
            // cboturma
            // 
            this.cboturma.FormattingEnabled = true;
            this.cboturma.Items.AddRange(new object[] {
            "Todas as Turmas"});
            this.cboturma.Location = new System.Drawing.Point(263, 62);
            this.cboturma.Name = "cboturma";
            this.cboturma.Size = new System.Drawing.Size(97, 21);
            this.cboturma.TabIndex = 91;
            this.cboturma.SelectedIndexChanged += new System.EventHandler(this.cboturma_SelectedIndexChanged);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltitulo.Location = new System.Drawing.Point(14, 50);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(239, 31);
            this.lbltitulo.TabIndex = 90;
            this.lbltitulo.Text = "Selecione a turma:";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 31);
            this.label1.TabIndex = 92;
            this.label1.Text = "Selecione a data:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpexport
            // 
            this.dtpexport.Enabled = false;
            this.dtpexport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpexport.Location = new System.Drawing.Point(263, 112);
            this.dtpexport.Name = "dtpexport";
            this.dtpexport.Size = new System.Drawing.Size(97, 20);
            this.dtpexport.TabIndex = 93;
            this.dtpexport.ValueChanged += new System.EventHandler(this.dtpexport_ValueChanged);
            // 
            // cmdvolta
            // 
            this.cmdvolta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdvolta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdvolta.FlatAppearance.BorderSize = 0;
            this.cmdvolta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdvolta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdvolta.Location = new System.Drawing.Point(12, 12);
            this.cmdvolta.Name = "cmdvolta";
            this.cmdvolta.Size = new System.Drawing.Size(56, 34);
            this.cmdvolta.TabIndex = 94;
            this.cmdvolta.Text = "Voltar";
            this.cmdvolta.UseVisualStyleBackColor = false;
            this.cmdvolta.Click += new System.EventHandler(this.cmdvolta_Click);
            // 
            // export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(413, 202);
            this.Controls.Add(this.cmdvolta);
            this.Controls.Add(this.dtpexport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboturma);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.cmdxml);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "export";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar Histórico";
            this.Load += new System.EventHandler(this.export_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdxml;
        private System.Windows.Forms.ComboBox cboturma;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpexport;
        private System.Windows.Forms.Button cmdvolta;
    }
}
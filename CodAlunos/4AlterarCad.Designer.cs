namespace CodAlunos
{
    partial class alterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alterar));
            this.cmdvolta = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.cboturma = new System.Windows.Forms.ComboBox();
            this.cmdalt = new System.Windows.Forms.Button();
            this.lblcad = new System.Windows.Forms.Label();
            this.lstra = new System.Windows.Forms.ListBox();
            this.cmddel = new System.Windows.Forms.Button();
            this.lstnome = new System.Windows.Forms.ListBox();
            this.cmdok = new System.Windows.Forms.Button();
            this.txtra = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdvolta
            // 
            this.cmdvolta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdvolta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdvolta.FlatAppearance.BorderSize = 0;
            this.cmdvolta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdvolta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdvolta.Location = new System.Drawing.Point(16, 11);
            this.cmdvolta.Name = "cmdvolta";
            this.cmdvolta.Size = new System.Drawing.Size(56, 34);
            this.cmdvolta.TabIndex = 86;
            this.cmdvolta.Text = "Voltar";
            this.cmdvolta.UseVisualStyleBackColor = false;
            this.cmdvolta.Click += new System.EventHandler(this.cmdvolta_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltitulo.Location = new System.Drawing.Point(10, 76);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(239, 31);
            this.lbltitulo.TabIndex = 88;
            this.lbltitulo.Text = "Selecione a turma:";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboturma
            // 
            this.cboturma.FormattingEnabled = true;
            this.cboturma.Location = new System.Drawing.Point(250, 88);
            this.cboturma.Name = "cboturma";
            this.cboturma.Size = new System.Drawing.Size(65, 21);
            this.cboturma.TabIndex = 89;
            this.cboturma.SelectedValueChanged += new System.EventHandler(this.cboturma_SelectedValueChanged);
            // 
            // cmdalt
            // 
            this.cmdalt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdalt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdalt.Enabled = false;
            this.cmdalt.FlatAppearance.BorderSize = 0;
            this.cmdalt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdalt.Location = new System.Drawing.Point(35, 357);
            this.cmdalt.Name = "cmdalt";
            this.cmdalt.Size = new System.Drawing.Size(146, 55);
            this.cmdalt.TabIndex = 90;
            this.cmdalt.Text = "Alterar";
            this.cmdalt.UseVisualStyleBackColor = false;
            this.cmdalt.Click += new System.EventHandler(this.cmdalt_Click);
            // 
            // lblcad
            // 
            this.lblcad.AutoSize = true;
            this.lblcad.BackColor = System.Drawing.Color.Transparent;
            this.lblcad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblcad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcad.Location = new System.Drawing.Point(11, 132);
            this.lblcad.Name = "lblcad";
            this.lblcad.Size = new System.Drawing.Size(116, 25);
            this.lblcad.TabIndex = 94;
            this.lblcad.Text = "Cadastros:";
            this.lblcad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstra
            // 
            this.lstra.FormattingEnabled = true;
            this.lstra.Location = new System.Drawing.Point(16, 161);
            this.lstra.Name = "lstra";
            this.lstra.ScrollAlwaysVisible = true;
            this.lstra.Size = new System.Drawing.Size(82, 160);
            this.lstra.TabIndex = 95;
            this.lstra.SelectedIndexChanged += new System.EventHandler(this.lstra_SelectedIndexChanged);
            // 
            // cmddel
            // 
            this.cmddel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmddel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmddel.Enabled = false;
            this.cmddel.FlatAppearance.BorderSize = 0;
            this.cmddel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmddel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmddel.Location = new System.Drawing.Point(188, 357);
            this.cmddel.Name = "cmddel";
            this.cmddel.Size = new System.Drawing.Size(146, 55);
            this.cmddel.TabIndex = 96;
            this.cmddel.Text = "Deletar";
            this.cmddel.UseVisualStyleBackColor = false;
            this.cmddel.Click += new System.EventHandler(this.cmddel_Click);
            // 
            // lstnome
            // 
            this.lstnome.FormattingEnabled = true;
            this.lstnome.Location = new System.Drawing.Point(103, 161);
            this.lstnome.Name = "lstnome";
            this.lstnome.ScrollAlwaysVisible = true;
            this.lstnome.Size = new System.Drawing.Size(276, 160);
            this.lstnome.TabIndex = 97;
            this.lstnome.SelectedIndexChanged += new System.EventHandler(this.lstnome_SelectedIndexChanged);
            // 
            // cmdok
            // 
            this.cmdok.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdok.Enabled = false;
            this.cmdok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdok.Location = new System.Drawing.Point(339, 326);
            this.cmdok.Margin = new System.Windows.Forms.Padding(2);
            this.cmdok.Name = "cmdok";
            this.cmdok.Size = new System.Drawing.Size(38, 39);
            this.cmdok.TabIndex = 98;
            this.cmdok.Text = "OK";
            this.cmdok.UseVisualStyleBackColor = false;
            this.cmdok.Visible = false;
            this.cmdok.Click += new System.EventHandler(this.cmdok_Click);
            // 
            // txtra
            // 
            this.txtra.Enabled = false;
            this.txtra.Location = new System.Drawing.Point(16, 326);
            this.txtra.Margin = new System.Windows.Forms.Padding(2);
            this.txtra.Name = "txtra";
            this.txtra.Size = new System.Drawing.Size(82, 20);
            this.txtra.TabIndex = 99;
            this.txtra.Visible = false;
            // 
            // txtnome
            // 
            this.txtnome.Enabled = false;
            this.txtnome.Location = new System.Drawing.Point(103, 326);
            this.txtnome.Margin = new System.Windows.Forms.Padding(2);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(232, 20);
            this.txtnome.TabIndex = 100;
            this.txtnome.Visible = false;
            // 
            // alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(488, 433);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtra);
            this.Controls.Add(this.cmdok);
            this.Controls.Add(this.lstnome);
            this.Controls.Add(this.cmddel);
            this.Controls.Add(this.lstra);
            this.Controls.Add(this.lblcad);
            this.Controls.Add(this.cmdalt);
            this.Controls.Add(this.cboturma);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.cmdvolta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "alterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Cadastro";
            this.Load += new System.EventHandler(this.alterar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdvolta;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.ComboBox cboturma;
        private System.Windows.Forms.Button cmdalt;
        private System.Windows.Forms.Label lblcad;
        private System.Windows.Forms.ListBox lstra;
        private System.Windows.Forms.Button cmddel;
        private System.Windows.Forms.ListBox lstnome;
        private System.Windows.Forms.Button cmdok;
        private System.Windows.Forms.TextBox txtra;
        private System.Windows.Forms.TextBox txtnome;
    }
}
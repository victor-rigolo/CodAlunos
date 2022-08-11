namespace CodAlunos
{
    partial class cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro));
            this.txtra = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblra = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.cmdfoto = new System.Windows.Forms.Button();
            this.lblfoto = new System.Windows.Forms.Label();
            this.imgaluno = new System.Windows.Forms.PictureBox();
            this.cboturma = new System.Windows.Forms.ComboBox();
            this.lblturm = new System.Windows.Forms.Label();
            this.cmdconfirma = new System.Windows.Forms.Button();
            this.cmdimport = new System.Windows.Forms.Button();
            this.cmdvolta = new System.Windows.Forms.Button();
            this.Importfoto = new System.Windows.Forms.OpenFileDialog();
            this.cmdexport = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.cmdaddturma = new System.Windows.Forms.Button();
            this.cboturmaexp = new System.Windows.Forms.ComboBox();
            this.Import = new System.Windows.Forms.OpenFileDialog();
            this.tmrconf = new System.Windows.Forms.Timer(this.components);
            this.lblexport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgaluno)).BeginInit();
            this.SuspendLayout();
            // 
            // txtra
            // 
            this.txtra.Location = new System.Drawing.Point(304, 222);
            this.txtra.MaxLength = 8;
            this.txtra.Name = "txtra";
            this.txtra.Size = new System.Drawing.Size(122, 20);
            this.txtra.TabIndex = 47;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(304, 176);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(484, 20);
            this.txtnome.TabIndex = 46;
            // 
            // lblra
            // 
            this.lblra.AutoSize = true;
            this.lblra.BackColor = System.Drawing.Color.Transparent;
            this.lblra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblra.Location = new System.Drawing.Point(300, 199);
            this.lblra.Name = "lblra";
            this.lblra.Size = new System.Drawing.Size(101, 20);
            this.lblra.TabIndex = 50;
            this.lblra.Text = "RA do aluno:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.Color.Transparent;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(300, 153);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(123, 20);
            this.lblnome.TabIndex = 49;
            this.lblnome.Text = "Nome Completo";
            // 
            // cmdfoto
            // 
            this.cmdfoto.BackColor = System.Drawing.Color.Silver;
            this.cmdfoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdfoto.Enabled = false;
            this.cmdfoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdfoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdfoto.Location = new System.Drawing.Point(31, 386);
            this.cmdfoto.Name = "cmdfoto";
            this.cmdfoto.Size = new System.Drawing.Size(174, 35);
            this.cmdfoto.TabIndex = 78;
            this.cmdfoto.Text = "Selec. Arquivo";
            this.cmdfoto.UseVisualStyleBackColor = false;
            this.cmdfoto.Click += new System.EventHandler(this.cmdfoto_Click);
            // 
            // lblfoto
            // 
            this.lblfoto.AutoSize = true;
            this.lblfoto.BackColor = System.Drawing.Color.Transparent;
            this.lblfoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfoto.Location = new System.Drawing.Point(27, 142);
            this.lblfoto.Name = "lblfoto";
            this.lblfoto.Size = new System.Drawing.Size(42, 20);
            this.lblfoto.TabIndex = 77;
            this.lblfoto.Text = "Foto";
            // 
            // imgaluno
            // 
            this.imgaluno.BackColor = System.Drawing.Color.Transparent;
            this.imgaluno.Location = new System.Drawing.Point(31, 165);
            this.imgaluno.Name = "imgaluno";
            this.imgaluno.Size = new System.Drawing.Size(174, 215);
            this.imgaluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgaluno.TabIndex = 76;
            this.imgaluno.TabStop = false;
            this.imgaluno.DoubleClick += new System.EventHandler(this.cmdfoto_Click);
            // 
            // cboturma
            // 
            this.cboturma.FormattingEnabled = true;
            this.cboturma.Location = new System.Drawing.Point(475, 222);
            this.cboturma.Name = "cboturma";
            this.cboturma.Size = new System.Drawing.Size(65, 21);
            this.cboturma.TabIndex = 79;
            this.cboturma.SelectedIndexChanged += new System.EventHandler(this.cboturma_SelectedIndexChanged);
            this.cboturma.TextChanged += new System.EventHandler(this.cboturma_TextChanged);
            // 
            // lblturm
            // 
            this.lblturm.AutoSize = true;
            this.lblturm.BackColor = System.Drawing.Color.Transparent;
            this.lblturm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblturm.Location = new System.Drawing.Point(471, 199);
            this.lblturm.Name = "lblturm";
            this.lblturm.Size = new System.Drawing.Size(54, 20);
            this.lblturm.TabIndex = 80;
            this.lblturm.Text = "Turma";
            // 
            // cmdconfirma
            // 
            this.cmdconfirma.BackColor = System.Drawing.Color.LightGreen;
            this.cmdconfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdconfirma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdconfirma.Enabled = false;
            this.cmdconfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdconfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdconfirma.ForeColor = System.Drawing.Color.Green;
            this.cmdconfirma.Location = new System.Drawing.Point(344, 323);
            this.cmdconfirma.Name = "cmdconfirma";
            this.cmdconfirma.Size = new System.Drawing.Size(159, 84);
            this.cmdconfirma.TabIndex = 81;
            this.cmdconfirma.Text = "Confirmar";
            this.cmdconfirma.UseVisualStyleBackColor = false;
            this.cmdconfirma.Click += new System.EventHandler(this.cmdconfirma_Click);
            // 
            // cmdimport
            // 
            this.cmdimport.BackColor = System.Drawing.Color.Silver;
            this.cmdimport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdimport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdimport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdimport.Location = new System.Drawing.Point(562, 357);
            this.cmdimport.Name = "cmdimport";
            this.cmdimport.Size = new System.Drawing.Size(119, 50);
            this.cmdimport.TabIndex = 82;
            this.cmdimport.Text = "Importar...";
            this.cmdimport.UseVisualStyleBackColor = false;
            this.cmdimport.Click += new System.EventHandler(this.cmdimport_Click);
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
            this.cmdvolta.TabIndex = 85;
            this.cmdvolta.Text = "Voltar";
            this.cmdvolta.UseVisualStyleBackColor = false;
            this.cmdvolta.Click += new System.EventHandler(this.cmdvolta_Click);
            // 
            // cmdexport
            // 
            this.cmdexport.BackColor = System.Drawing.Color.Silver;
            this.cmdexport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdexport.Enabled = false;
            this.cmdexport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdexport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdexport.Location = new System.Drawing.Point(687, 357);
            this.cmdexport.Name = "cmdexport";
            this.cmdexport.Size = new System.Drawing.Size(119, 50);
            this.cmdexport.TabIndex = 86;
            this.cmdexport.Text = "Exportar...";
            this.cmdexport.UseVisualStyleBackColor = false;
            this.cmdexport.Click += new System.EventHandler(this.cmdexport_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltitulo.Location = new System.Drawing.Point(68, 54);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(698, 51);
            this.lbltitulo.TabIndex = 83;
            this.lbltitulo.Text = "Cadastre abaixo os dados do aluno";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdaddturma
            // 
            this.cmdaddturma.BackColor = System.Drawing.Color.Silver;
            this.cmdaddturma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdaddturma.Enabled = false;
            this.cmdaddturma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdaddturma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdaddturma.Location = new System.Drawing.Point(546, 205);
            this.cmdaddturma.Name = "cmdaddturma";
            this.cmdaddturma.Size = new System.Drawing.Size(96, 53);
            this.cmdaddturma.TabIndex = 88;
            this.cmdaddturma.Text = "Adicionar Turma";
            this.cmdaddturma.UseVisualStyleBackColor = false;
            this.cmdaddturma.Click += new System.EventHandler(this.cmdaddturma_Click);
            // 
            // cboturmaexp
            // 
            this.cboturmaexp.FormattingEnabled = true;
            this.cboturmaexp.Location = new System.Drawing.Point(672, 323);
            this.cboturmaexp.Margin = new System.Windows.Forms.Padding(2);
            this.cboturmaexp.Name = "cboturmaexp";
            this.cboturmaexp.Size = new System.Drawing.Size(116, 21);
            this.cboturmaexp.TabIndex = 89;
            this.cboturmaexp.SelectedIndexChanged += new System.EventHandler(this.cboturmaexp_SelectedIndexChanged);
            // 
            // Import
            // 
            this.Import.FileOk += new System.ComponentModel.CancelEventHandler(this.import_FileOk);
            // 
            // tmrconf
            // 
            this.tmrconf.Enabled = true;
            this.tmrconf.Tick += new System.EventHandler(this.tmrconf_Tick);
            // 
            // lblexport
            // 
            this.lblexport.BackColor = System.Drawing.Color.Transparent;
            this.lblexport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblexport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexport.Location = new System.Drawing.Point(575, 303);
            this.lblexport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblexport.Name = "lblexport";
            this.lblexport.Size = new System.Drawing.Size(93, 41);
            this.lblexport.TabIndex = 90;
            this.lblexport.Text = "Turma a ser exportada:";
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(832, 433);
            this.Controls.Add(this.lblexport);
            this.Controls.Add(this.cboturmaexp);
            this.Controls.Add(this.cmdaddturma);
            this.Controls.Add(this.cmdexport);
            this.Controls.Add(this.cmdvolta);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.cmdimport);
            this.Controls.Add(this.cmdconfirma);
            this.Controls.Add(this.lblturm);
            this.Controls.Add(this.cboturma);
            this.Controls.Add(this.cmdfoto);
            this.Controls.Add(this.lblfoto);
            this.Controls.Add(this.imgaluno);
            this.Controls.Add(this.txtra);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblra);
            this.Controls.Add(this.lblnome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgaluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtra;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblra;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Button cmdfoto;
        private System.Windows.Forms.Label lblfoto;
        private System.Windows.Forms.PictureBox imgaluno;
        private System.Windows.Forms.ComboBox cboturma;
        private System.Windows.Forms.Label lblturm;
        private System.Windows.Forms.Button cmdconfirma;
        private System.Windows.Forms.Button cmdimport;
        private System.Windows.Forms.Button cmdvolta;
        private System.Windows.Forms.OpenFileDialog Importfoto;
        private System.Windows.Forms.Button cmdexport;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button cmdaddturma;
        private System.Windows.Forms.ComboBox cboturmaexp;
        private System.Windows.Forms.OpenFileDialog Import;
        private System.Windows.Forms.Timer tmrconf;
        private System.Windows.Forms.Label lblexport;
    }
}
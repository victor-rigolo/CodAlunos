namespace CodAlunos
{
    partial class entrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(entrada));
            this.txtnum = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblcerto = new System.Windows.Forms.Label();
            this.lblerro = new System.Windows.Forms.Label();
            this.cmdvolta = new System.Windows.Forms.Button();
            this.tmrlbl = new System.Windows.Forms.Timer(this.components);
            this.lblra = new System.Windows.Forms.Label();
            this.imgaluno2 = new System.Windows.Forms.PictureBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.tmrtxt = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgaluno2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnum
            // 
            this.txtnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.Location = new System.Drawing.Point(827, 73);
            this.txtnum.MaxLength = 12;
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(1, 31);
            this.txtnum.TabIndex = 11;
            this.txtnum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnum_KeyDown);
            // 
            // lblnome
            // 
            this.lblnome.AllowDrop = true;
            this.lblnome.AutoEllipsis = true;
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.Color.Transparent;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(32, 275);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(0, 37);
            this.lblnome.TabIndex = 39;
            this.lblnome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcerto
            // 
            this.lblcerto.AutoSize = true;
            this.lblcerto.BackColor = System.Drawing.Color.Transparent;
            this.lblcerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcerto.ForeColor = System.Drawing.Color.Green;
            this.lblcerto.Location = new System.Drawing.Point(753, 440);
            this.lblcerto.Name = "lblcerto";
            this.lblcerto.Size = new System.Drawing.Size(225, 55);
            this.lblcerto.TabIndex = 40;
            this.lblcerto.Text = "Presente";
            this.lblcerto.Visible = false;
            // 
            // lblerro
            // 
            this.lblerro.AutoSize = true;
            this.lblerro.BackColor = System.Drawing.Color.Transparent;
            this.lblerro.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblerro.Location = new System.Drawing.Point(232, 190);
            this.lblerro.Name = "lblerro";
            this.lblerro.Size = new System.Drawing.Size(414, 110);
            this.lblerro.TabIndex = 41;
            this.lblerro.Text = "            Erro\r\nTente novamente";
            this.lblerro.Visible = false;
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
            this.cmdvolta.TabIndex = 0;
            this.cmdvolta.Text = "Voltar";
            this.cmdvolta.UseVisualStyleBackColor = false;
            this.cmdvolta.Click += new System.EventHandler(this.btnvolta_Click);
            // 
            // tmrlbl
            // 
            this.tmrlbl.Enabled = true;
            this.tmrlbl.Interval = 4000;
            this.tmrlbl.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // lblra
            // 
            this.lblra.AllowDrop = true;
            this.lblra.AutoSize = true;
            this.lblra.BackColor = System.Drawing.Color.Transparent;
            this.lblra.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblra.Location = new System.Drawing.Point(32, 185);
            this.lblra.Name = "lblra";
            this.lblra.Size = new System.Drawing.Size(0, 61);
            this.lblra.TabIndex = 42;
            this.lblra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgaluno2
            // 
            this.imgaluno2.BackColor = System.Drawing.Color.Transparent;
            this.imgaluno2.Location = new System.Drawing.Point(763, 168);
            this.imgaluno2.Name = "imgaluno2";
            this.imgaluno2.Size = new System.Drawing.Size(206, 252);
            this.imgaluno2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgaluno2.TabIndex = 43;
            this.imgaluno2.TabStop = false;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltitulo.Location = new System.Drawing.Point(117, 62);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(822, 55);
            this.lbltitulo.TabIndex = 37;
            this.lbltitulo.Text = "Aproxime o código de barras no leitor";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tmrtxt
            // 
            this.tmrtxt.Enabled = true;
            this.tmrtxt.Interval = 2000;
            this.tmrtxt.Tick += new System.EventHandler(this.tmrtxt_Tick);
            // 
            // entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1028, 604);
            this.Controls.Add(this.imgaluno2);
            this.Controls.Add(this.lblra);
            this.Controls.Add(this.cmdvolta);
            this.Controls.Add(this.lblerro);
            this.Controls.Add(this.lblcerto);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lbltitulo);
            this.Name = "entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            this.Load += new System.EventHandler(this.entrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgaluno2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblcerto;
        private System.Windows.Forms.Label lblerro;
        private System.Windows.Forms.Button cmdvolta;
        private System.Windows.Forms.Timer tmrlbl;
        private System.Windows.Forms.Label lblra;
        private System.Windows.Forms.PictureBox imgaluno2;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Timer tmrtxt;
    }
}
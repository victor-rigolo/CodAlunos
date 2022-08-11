namespace CodAlunos
{
    partial class anular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anular));
            this.cmdvolta = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.cboturma = new System.Windows.Forms.ComboBox();
            this.cmdanular = new System.Windows.Forms.Button();
            this.lstanular = new System.Windows.Forms.ListBox();
            this.stpanular = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdvolta
            // 
            this.cmdvolta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdvolta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdvolta.FlatAppearance.BorderSize = 0;
            this.cmdvolta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdvolta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdvolta.Location = new System.Drawing.Point(10, 11);
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
            this.lbltitulo.Location = new System.Drawing.Point(4, 138);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(239, 31);
            this.lbltitulo.TabIndex = 88;
            this.lbltitulo.Text = "Selecione a turma:";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboturma
            // 
            this.cboturma.Enabled = false;
            this.cboturma.FormattingEnabled = true;
            this.cboturma.Location = new System.Drawing.Point(249, 148);
            this.cboturma.Name = "cboturma";
            this.cboturma.Size = new System.Drawing.Size(65, 21);
            this.cboturma.TabIndex = 89;
            this.cboturma.SelectedIndexChanged += new System.EventHandler(this.cboturma_SelectedIndexChanged);
            // 
            // cmdanular
            // 
            this.cmdanular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdanular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdanular.Enabled = false;
            this.cmdanular.FlatAppearance.BorderSize = 0;
            this.cmdanular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdanular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdanular.Location = new System.Drawing.Point(10, 433);
            this.cmdanular.Name = "cmdanular";
            this.cmdanular.Size = new System.Drawing.Size(146, 55);
            this.cmdanular.TabIndex = 90;
            this.cmdanular.Text = "ANULAR";
            this.cmdanular.UseVisualStyleBackColor = false;
            this.cmdanular.Click += new System.EventHandler(this.cmdanular_Click);
            // 
            // lstanular
            // 
            this.lstanular.FormattingEnabled = true;
            this.lstanular.Location = new System.Drawing.Point(10, 227);
            this.lstanular.MultiColumn = true;
            this.lstanular.Name = "lstanular";
            this.lstanular.Size = new System.Drawing.Size(372, 199);
            this.lstanular.TabIndex = 91;
            this.lstanular.SelectedIndexChanged += new System.EventHandler(this.lstanular_SelectedIndexChanged);
            // 
            // stpanular
            // 
            this.stpanular.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.stpanular.Location = new System.Drawing.Point(233, 105);
            this.stpanular.Name = "stpanular";
            this.stpanular.Size = new System.Drawing.Size(115, 20);
            this.stpanular.TabIndex = 92;
            this.stpanular.ValueChanged += new System.EventHandler(this.stpanular_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(4, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 31);
            this.label1.TabIndex = 93;
            this.label1.Text = "Selecione a data:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(5, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 94;
            this.label2.Text = "Presenças:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // anular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(406, 499);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stpanular);
            this.Controls.Add(this.lstanular);
            this.Controls.Add(this.cmdanular);
            this.Controls.Add(this.cboturma);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.cmdvolta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "anular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anular Presença";
            this.Load += new System.EventHandler(this.anular_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdvolta;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.ComboBox cboturma;
        private System.Windows.Forms.Button cmdanular;
        private System.Windows.Forms.ListBox lstanular;
        private System.Windows.Forms.DateTimePicker stpanular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
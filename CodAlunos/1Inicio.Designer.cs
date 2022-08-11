namespace CodAlunos
{
    partial class telainicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telainicial));
            this.cmdinicio = new System.Windows.Forms.Button();
            this.cmdcad = new System.Windows.Forms.Button();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.cmdaltercad = new System.Windows.Forms.Button();
            this.cmdexport = new System.Windows.Forms.Button();
            this.cmdanula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdinicio
            // 
            this.cmdinicio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdinicio.BackColor = System.Drawing.Color.Transparent;
            this.cmdinicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdinicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdinicio.FlatAppearance.BorderSize = 0;
            this.cmdinicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.cmdinicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdinicio.Font = new System.Drawing.Font("Product Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdinicio.Image = ((System.Drawing.Image)(resources.GetObject("cmdinicio.Image")));
            this.cmdinicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdinicio.Location = new System.Drawing.Point(217, 206);
            this.cmdinicio.Name = "cmdinicio";
            this.cmdinicio.Size = new System.Drawing.Size(313, 139);
            this.cmdinicio.TabIndex = 0;
            this.cmdinicio.Text = "Iniciar";
            this.cmdinicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdinicio.UseVisualStyleBackColor = true;
            this.cmdinicio.Click += new System.EventHandler(this.cmdinicio_Click);
            // 
            // cmdcad
            // 
            this.cmdcad.BackColor = System.Drawing.Color.Transparent;
            this.cmdcad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdcad.FlatAppearance.BorderSize = 0;
            this.cmdcad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdcad.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcad.Image = ((System.Drawing.Image)(resources.GetObject("cmdcad.Image")));
            this.cmdcad.Location = new System.Drawing.Point(135, 351);
            this.cmdcad.Name = "cmdcad";
            this.cmdcad.Size = new System.Drawing.Size(186, 130);
            this.cmdcad.TabIndex = 1;
            this.cmdcad.Text = "Cadastrar Aluno";
            this.cmdcad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdcad.UseVisualStyleBackColor = false;
            this.cmdcad.Click += new System.EventHandler(this.cmdcad_Click);
            // 
            // piclogo
            // 
            this.piclogo.BackColor = System.Drawing.Color.Transparent;
            this.piclogo.Image = ((System.Drawing.Image)(resources.GetObject("piclogo.Image")));
            this.piclogo.Location = new System.Drawing.Point(401, -22);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(224, 187);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.piclogo.TabIndex = 3;
            this.piclogo.TabStop = false;
            // 
            // cmdaltercad
            // 
            this.cmdaltercad.BackColor = System.Drawing.Color.Transparent;
            this.cmdaltercad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdaltercad.FlatAppearance.BorderSize = 0;
            this.cmdaltercad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdaltercad.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdaltercad.Image = ((System.Drawing.Image)(resources.GetObject("cmdaltercad.Image")));
            this.cmdaltercad.Location = new System.Drawing.Point(419, 351);
            this.cmdaltercad.Name = "cmdaltercad";
            this.cmdaltercad.Size = new System.Drawing.Size(186, 130);
            this.cmdaltercad.TabIndex = 4;
            this.cmdaltercad.Text = "Alterar Cadastros";
            this.cmdaltercad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdaltercad.UseVisualStyleBackColor = false;
            this.cmdaltercad.Click += new System.EventHandler(this.cmdaltercad_Click);
            // 
            // cmdexport
            // 
            this.cmdexport.BackColor = System.Drawing.Color.Transparent;
            this.cmdexport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdexport.FlatAppearance.BorderSize = 0;
            this.cmdexport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdexport.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdexport.Image = ((System.Drawing.Image)(resources.GetObject("cmdexport.Image")));
            this.cmdexport.Location = new System.Drawing.Point(712, 351);
            this.cmdexport.Name = "cmdexport";
            this.cmdexport.Size = new System.Drawing.Size(186, 130);
            this.cmdexport.TabIndex = 5;
            this.cmdexport.Text = "Exportar Histórico";
            this.cmdexport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdexport.UseVisualStyleBackColor = false;
            this.cmdexport.Click += new System.EventHandler(this.cmdexport_Click);
            // 
            // cmdanula
            // 
            this.cmdanula.BackColor = System.Drawing.Color.Transparent;
            this.cmdanula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdanula.FlatAppearance.BorderSize = 0;
            this.cmdanula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdanula.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdanula.Image = ((System.Drawing.Image)(resources.GetObject("cmdanula.Image")));
            this.cmdanula.Location = new System.Drawing.Point(612, 206);
            this.cmdanula.Name = "cmdanula";
            this.cmdanula.Size = new System.Drawing.Size(136, 139);
            this.cmdanula.TabIndex = 6;
            this.cmdanula.Text = "Anular Presença";
            this.cmdanula.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdanula.UseVisualStyleBackColor = false;
            this.cmdanula.Click += new System.EventHandler(this.cmdanula_Click);
            // 
            // telainicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1019, 576);
            this.Controls.Add(this.cmdanula);
            this.Controls.Add(this.cmdexport);
            this.Controls.Add(this.cmdaltercad);
            this.Controls.Add(this.piclogo);
            this.Controls.Add(this.cmdcad);
            this.Controls.Add(this.cmdinicio);
            this.MaximizeBox = false;
            this.Name = "telainicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodAlunos";
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdinicio;
        private System.Windows.Forms.Button cmdcad;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Button cmdaltercad;
        private System.Windows.Forms.Button cmdexport;
        private System.Windows.Forms.Button cmdanula;

    }
}
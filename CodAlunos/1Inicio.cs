using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodAlunos
{
    public partial class telainicial : Form
    {
        public telainicial()
        {
            InitializeComponent();
        }

        private void cmdinicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            var inicio = new entrada();
            inicio.Closed += (s, args) => this.Close();
            inicio.Show();
        }

        private void cmdaltercad_Click(object sender, EventArgs e)
        {
            var alt = new alterar();
            alt.Show();
        }

        private void cmdexport_Click(object sender, EventArgs e)
        {
            var exp = new export();
            exp.Show();
        }

        private void cmdcad_Click(object sender, EventArgs e)
        {
            var cad = new cadastro();
            cad.Show();
        }

        private void cmdanula_Click(object sender, EventArgs e)
        {
            var exp = new anular();
            exp.Show();
        }


    }
}

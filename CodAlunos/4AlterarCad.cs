using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace CodAlunos
{
    public partial class alterar : Form
    {
        Seguranca seguranca = new Seguranca();


        public void addalunos() 
        {

            lstra.Items.Clear();
            lstnome.Items.Clear();

            string database = "SERVER=localhost;DATABASE=escola;UID=root;PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(database);
            MySqlDataReader reader = null; ;  //conexão do BD
            MySqlCommand command = connection.CreateCommand();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand("select * from alunos where turma=@turma order by nome asc", connection);
            cmd.Parameters.AddWithValue("@turma", cboturma.Text);

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lstra.Items.Add(reader[0].ToString().Substring(0, 8));
                lstnome.Items.Add(reader[1]);
            }
            cmddel.Enabled = true;
        
        
        }


        public void sincronia(object sender)
        {
            int selecionado = ((ListBox)sender).SelectedIndex;
            lstnome.SelectedIndex = selecionado;
            lstra.SelectedIndex = selecionado;
            cmdalt.Enabled = true;
            txtnome.Clear();
            txtra.Clear();
            cmdok.Enabled = false;
            txtnome.Enabled = false;
            cmdok.Visible = false;
            txtnome.Visible = false;
            txtra.Visible = false;
            cmdalt.Enabled = true;
        }


        public void puxarturmasbanco(String turma)
        {
            int cont = 0;
            int aux = 0;

            while (cont <= cboturma.Items.Count - 1)
            {
                if (turma == cboturma.Items[cont].ToString())
                    aux++;

                cont++;
            }
            if (aux == 0)
                cboturma.Items.Add(turma);

        }


        public alterar()
        {
            InitializeComponent();

        }

        private void alterar_Load(object sender, EventArgs e)
        {
            string database = "SERVER=localhost;DATABASE=escola;UID=root;PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(database);
            MySqlDataReader reader = null; ;  //conexão do BD
            MySqlCommand command = connection.CreateCommand();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand("select * from alunos order by turma asc", connection);

            //leitura do BD
            reader = cmd.ExecuteReader();

            while (reader.Read())
                puxarturmasbanco(reader[2].ToString());


            connection.Close();


        }

        private void cmdvolta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdalt_Click(object sender, EventArgs e)
        {
            txtra.Visible = true;
            txtnome.Visible = true;
            cmdok.Visible = true;
            txtnome.Enabled = true;
            cmdok.Enabled = true;
            txtnome.Text = lstnome.SelectedItem.ToString();
            txtra.Text = lstra.SelectedItem.ToString();
            cmdalt.Enabled = false;
            
        }

        private void cboturma_SelectedValueChanged(object sender, EventArgs e)
        {
            addalunos();
        }

        private void cmddel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Você está certo/a de deletar o cadastro de RA: " + lstra.SelectedItem.ToString() + "\n Aluno: " + lstnome.SelectedItem.ToString() + "?", "Deletar Cadastro", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes) 
            {
                txtnome.Clear();
                txtra.Clear();
                cmdok.Enabled = false;
                txtnome.Enabled = false;
                cmdok.Visible = false;
                txtnome.Visible = false;
                txtra.Visible = false;
                cmdalt.Enabled = false;


                string database = "SERVER=localhost;DATABASE=escola;UID=root;PASSWORD=;";
                MySqlConnection connection = new MySqlConnection(database);
                MySqlDataReader reader = null; ;  //conexão do BD

                connection.Open();

                MySqlCommand cmd = new MySqlCommand("DELETE FROM alunos WHERE ra=@ra", connection);
                cmd.Parameters.AddWithValue("@ra", lstra.SelectedItem.ToString() + seguranca.encripta(lstnome.SelectedItem.ToString().Substring(0,3).ToUpper()));

                //leitura do BD
                reader = cmd.ExecuteReader();
                int aux = lstnome.SelectedIndex;
                lstnome.Items.RemoveAt(aux);
                lstra.Items.RemoveAt(aux);
                connection.Close();
            
            }   
        
        }


        private void lstra_SelectedIndexChanged(object sender, EventArgs e)
        {
            sincronia(sender);
        }

        private void lstnome_SelectedIndexChanged(object sender, EventArgs e)
        {
            sincronia(sender);
            
        }

        private void cmdok_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Você está certo/a de alterar o cadastro de RA: " + txtra.Text + "\n Aluno: " + txtnome.Text + "?", "Alterar Cadastro", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                string database = "SERVER=localhost;DATABASE=escola;UID=root;PASSWORD=;";
                MySqlConnection connection = new MySqlConnection(database);
                MySqlDataReader reader = null; ;  //conexão do BD

                connection.Open();

                MySqlCommand cmd = new MySqlCommand("UPDATE alunos SET nome = '" + txtnome.Text + "' WHERE ra=@ra", connection);
                cmd.Parameters.AddWithValue("@ra", txtra.Text + seguranca.encripta(txtnome.Text.Substring(0, 3).ToUpper()));

                //leitura do BD
                reader = cmd.ExecuteReader();

                addalunos();

                txtnome.Clear();
                txtra.Clear();
                cmdok.Enabled = false;
                txtnome.Enabled = false;
                cmdok.Visible = false;
                txtnome.Visible = false;
                txtra.Visible = false;
                cmdalt.Enabled = false;


            }
        }
    }
}

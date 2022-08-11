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
    public partial class anular : Form
    {

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



        public anular()
        {
            InitializeComponent();

        }

        private void cmdvolta_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void stpanular_ValueChanged(object sender, EventArgs e)
        {
            if (cboturma.Enabled == true) 
            {
                lstanular.Items.Clear();

                String turmaux = cboturma.Text;
                String dataux = stpanular.Text.Substring(0, 10);

                string database = "SERVER=localhost;DATABASE=escola;UID=root;PASSWORD=;";
                MySqlConnection connection = new MySqlConnection(database);
                MySqlDataReader reader = null; ;  //conexão do BD
                MySqlCommand command = connection.CreateCommand();

                connection.Open();

                MySqlCommand cmd = new MySqlCommand("select * from presenca where data=@data AND turma=@turma order by nome asc", connection);
                cmd.Parameters.AddWithValue("@turma", turmaux);
                cmd.Parameters.AddWithValue("@data", dataux);

                reader = cmd.ExecuteReader();

                // criação de xml

                while (reader.Read())
                {

                    lstanular.Items.Add(reader[2]);

                }

                connection.Close();
            
                }else
                    cboturma.Enabled = true;

        }


        private void cboturma_SelectedIndexChanged(object sender, EventArgs e)
        {
 

            lstanular.Items.Clear();

            String turmaux = cboturma.Text;
            String dataux = stpanular.Text.Substring(0, 10);

            string database = "SERVER=localhost;DATABASE=escola;UID=root;PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(database);
            MySqlDataReader reader = null; ;  //conexão do BD
            MySqlCommand command = connection.CreateCommand();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand("select * from presenca where data=@data AND turma=@turma order by nome asc", connection);
            cmd.Parameters.AddWithValue("@turma", turmaux);
            cmd.Parameters.AddWithValue("@data", dataux);

            reader = cmd.ExecuteReader();

            // criação de xml

            while (reader.Read())
            {

                lstanular.Items.Add(reader[2]);

            }


            connection.Close();


        }

        private void cmdanular_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Você está certo/a de remover a presença do Aluno: " + lstanular.SelectedItem.ToString() + "?", "Anular Presença", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {

                string database = "SERVER=localhost;DATABASE=escola;UID=root;PASSWORD=;";
                MySqlConnection connection = new MySqlConnection(database);
                MySqlDataReader reader = null; ;  //conexão do BD

                connection.Open();

                MySqlCommand cmd = new MySqlCommand("DELETE FROM presenca WHERE nome=@nome", connection);
                cmd.Parameters.AddWithValue("@nome", lstanular.SelectedItem.ToString().Trim());
                
                reader = cmd.ExecuteReader();

                connection.Close();

                lstanular.Items.Remove(lstanular.SelectedItem);

            }  

        }

        private void anular_Load(object sender, EventArgs e)
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

        private void lstanular_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdanular.Enabled = true;
        }

    }
}

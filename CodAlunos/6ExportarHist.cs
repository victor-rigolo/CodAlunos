using System;
using System.IO;
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
    public partial class export : Form
    {
        String nome;
        String ra;
        String data;
        String hora;
        String turma;
        int turmas = 0;

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


        public void arquivomorto(String caminho, String nome, String ra, String data, String hora, String turma)
        {



            File.AppendAllText(@caminho, "  <DADOS>" + Environment.NewLine);

            File.AppendAllText(@caminho, "      <NOME>" + nome + "</NOME>" + Environment.NewLine);
            File.AppendAllText(@caminho, "      <RA>" + ra + "</RA>" + Environment.NewLine);
            File.AppendAllText(@caminho, "      <DATA>" + data + "</DATA>" + Environment.NewLine);
            File.AppendAllText(@caminho, "      <HORA>" + hora + "</HORA>" + Environment.NewLine);
            if (turmas == 1)
                File.AppendAllText(@caminho, "      <TURMA>" + turma + "</TURMA>" + Environment.NewLine);


            File.AppendAllText(@caminho, "  </DADOS>" + Environment.NewLine);

        }


        public export()
        {
            InitializeComponent();
        }


        private void cmdxml_Click(object sender, EventArgs e)
        {
            String turmaux = cboturma.Text;
            String dataux = dtpexport.Text.Substring(0, 10);
            String caminho = "C:\\CodAlunos\\HISTORICOS\\" + cboturma.Text + "_" + dtpexport.Value.ToString().Substring(0, 2) + "_" + dtpexport.Value.ToString().Substring(3, 2) + "_" + dtpexport.Value.ToString().Substring(6, 4) + ".xml";


            string database = "SERVER=localhost;DATABASE=escola;UID=root;PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(database);
            MySqlDataReader reader = null; ;  //conexão do BD
            MySqlCommand command = connection.CreateCommand();
            MySqlCommand cmd = new MySqlCommand();
            connection.Open();

            if (cboturma.Text == "Todas as Turmas")
            {
                cmd = new MySqlCommand("select * from presenca where data=@data order by turma asc, nome", connection);
                cmd.Parameters.AddWithValue("@data", dataux);
                turmas = 1;
            
            }
            else
            {
                turmas = 0;
                cmd = new MySqlCommand("select * from presenca where data=@data AND turma=@turma order by nome asc", connection);
                cmd.Parameters.AddWithValue("@turma", turmaux);
                cmd.Parameters.AddWithValue("@data", dataux);
            }
            reader = cmd.ExecuteReader();

            // criação de xml
            File.AppendAllText(@caminho, @"<?xml version=""1.0"" encoding=""ISO-8859-1""?>" + Environment.NewLine + "<REGISTRO>" + Environment.NewLine);

            while (reader.Read())
            {

                ra = reader[1].ToString().Substring(0, 8);
                nome = reader[2].ToString();
                data = reader[3].ToString();
                hora = reader[4].ToString();
                turma = reader[5].ToString();
                arquivomorto(caminho, nome, ra, data, hora, turma);

            }

            File.AppendAllText(@caminho, "</REGISTRO>" + Environment.NewLine);
            MessageBox.Show("Histórico Exportado com Sucesso!!!");
            connection.Close();
        }

        private void export_Load(object sender, EventArgs e)
        {
            string database = "SERVER=localhost;DATABASE=escola;UID=root;PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(database);
            MySqlDataReader reader = null; ;  //conexão do BD
            MySqlCommand command = connection.CreateCommand();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand("select * from presenca order by turma asc", connection);

            //leitura do BD
            reader = cmd.ExecuteReader();

            while (reader.Read())
                puxarturmasbanco(reader[5].ToString());


            connection.Close();
        }

        private void dtpexport_ValueChanged(object sender, EventArgs e)
        {
            cmdxml.Enabled = true;
        }

        private void cboturma_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpexport.Enabled = true;
        }

        private void cmdvolta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

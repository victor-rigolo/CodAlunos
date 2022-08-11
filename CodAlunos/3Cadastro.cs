using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace CodAlunos
{
    public partial class cadastro : Form
    {
        int cboaux = 0;

        public void adicionarturmas(String turma)
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
            {
                cboturma.Items.Add(turma);
                cboturmaexp.Items.Add(turma);
                
            }
            else if(cboaux == 1)
                MessageBox.Show("Turma já existente!!!");

        }




        public void puxarturmas() 
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
                adicionarturmas(reader[2].ToString());


            connection.Close();
        
        }


        public void arquivomorto(String caminho, String nome, String ra, String turma) 
        {



            File.AppendAllText(@caminho, "  <DADOS>" + Environment.NewLine);

            File.AppendAllText(@caminho, "      <NOME>" + nome + "</NOME>" + Environment.NewLine);
            File.AppendAllText(@caminho, "      <RA>" + ra + "</RA>" + Environment.NewLine);
            File.AppendAllText(@caminho, "      <TURMA>" + turma + "</TURMA>" + Environment.NewLine);

            File.AppendAllText(@caminho, "  </DADOS>" + Environment.NewLine);



        }



        string foto;
        string turma = "";
        string nome = "";
        string ra = "";

        public cadastro()
        {
            InitializeComponent();
        }

        private void cmdconfirma_Click(object sender, EventArgs e)
        {

            Seguranca seguranca = new Seguranca();

            turma = cboturma.Text;
            nome = txtnome.Text;
            ra = txtra.Text.Substring(0, 8) + seguranca.encripta(nome.Substring(0,3).ToUpper());
            foto = @"C:\\CodAlunos\\IMGALUNOS\\" + txtra.Text + ".jpg";

            string database = "SERVER=localhost;DATABASE=escola;UID=root;PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(database);
            MySqlCommand command = connection.CreateCommand();
            
            connection.Open();
           
            command.CommandText = "INSERT INTO alunos (ra, nome, turma, foto)" +
            "VALUES('" + ra + "','" + txtnome.Text + "','" + turma +  "','"  + foto +"')";

            MySqlDataReader Query = command.ExecuteReader();
            connection.Close();

            txtnome.Clear();
            txtra.Clear();
            cboturma.Text = "";
            cmdfoto.Enabled = false;
            cmdconfirma.Enabled = false;
            cmdexport.Enabled = false;
            cboturmaexp.Text = "";
            cmdaddturma.Enabled = false;
            txtnome.Focus();
            

            MessageBox.Show("Gravado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }


        private void cmdfoto_Click(object sender, EventArgs e)
        {
           
                Importfoto.InitialDirectory = @"C:\CodAlunos\IMGALUNOS\";
                Importfoto.Title = "Selecionar Foto";

                Importfoto.CheckFileExists = true;
                Importfoto.CheckPathExists = true;

                Importfoto.DefaultExt = "jpg";
                Importfoto.Filter = "Image files (*.jpg; *.jpeg)|*.jpg; *.jpeg";
                Importfoto.FilterIndex = 2;
                Importfoto.RestoreDirectory = true;
                Importfoto.ReadOnlyChecked = true;
                                                    
            if (Importfoto.ShowDialog() == DialogResult.OK) 
            {
                      
                    imgaluno.Image = new Bitmap(Importfoto.FileName);
                    Importfoto.FileName = foto; 
                
            }
       }

      
        
      private void cmdvolta_Click(object sender, EventArgs e)
      {
            this.Close();
      }

      private void cmdexport_Click(object sender, EventArgs e)
      {
          String turmaux = cboturmaexp.Text;
          String caminho = "C:\\CodAlunos\\TURMAS\\" + cboturmaexp.Text + ".xml";


          string database = "SERVER=localhost;DATABASE=escola;UID=root;PASSWORD=;";
          MySqlConnection connection = new MySqlConnection(database);
          MySqlDataReader reader = null; ;  //conexão do BD
          MySqlCommand command = connection.CreateCommand();

          connection.Open();

          MySqlCommand cmd = new MySqlCommand("select * from alunos where turma=@turma order by nome asc", connection);
          cmd.Parameters.AddWithValue("@turma", turmaux);

          reader = cmd.ExecuteReader();

          // criação de xml

          File.AppendAllText(@caminho, @"<?xml version=""1.0"" encoding=""ISO-8859-1""?>" + Environment.NewLine + "<REGISTRO>" + Environment.NewLine);

          while (reader.Read())
          {

              ra = reader[0].ToString().Substring(0, 8);
              nome = reader[1].ToString();

              arquivomorto(caminho, nome, ra, turmaux);
          }

          File.AppendAllText(@caminho, "</REGISTRO>" + Environment.NewLine);

          MessageBox.Show("Turma Exportada com Sucesso!!!");
          
      }

      

      private void cmdaddturma_Click(object sender, EventArgs e)
      {
          cboaux = 1;
          adicionarturmas(cboturma.Text);
      }

      private void cadastro_Load(object sender, EventArgs e)
      {
          puxarturmas();
          txtnome.Focus();
      }

      private void cmdimport_Click(object sender, EventArgs e)
      {

          Import.InitialDirectory = @"C:\\";
          Import.Title = "Selecionar Arquivo";

          Import.CheckFileExists = true;
          Import.CheckPathExists = true;

          Import.DefaultExt = "xml";
          Import.Filter = "Text Files (*.xml)|*.xml";
          Import.FilterIndex = 2;
          Import.RestoreDirectory = true;
          Import.ReadOnlyChecked = true;
          Import.ShowDialog();


      
      }

      private void import_FileOk(object sender, CancelEventArgs e)
      {



          Seguranca seguranca = new Seguranca();

          XmlDocument xmlDoc = new XmlDocument();
          xmlDoc.Load(Import.FileName);

          XmlNodeList dataNodes = xmlDoc.SelectNodes("/REGISTRO/DADOS");

          string database = "SERVER=localhost;DATABASE=escola;UID=root;PASSWORD=;";
          MySqlConnection connection = new MySqlConnection(database);
          MySqlCommand command = connection.CreateCommand();

          


          foreach (XmlNode node in dataNodes)
          {
              connection.Open();

              String ra = node.SelectSingleNode("RA").InnerText.ToString() + seguranca.encripta(node.SelectSingleNode("NOME").InnerText.ToString().ToUpper().Substring(0, 3));
              String nome = node.SelectSingleNode("NOME").InnerText.ToString();
              String turma = node.SelectSingleNode("TURMA").InnerText.ToString();
              String foto = @"C:\\CodAlunos\\IMGALUNOS\\" + node.SelectSingleNode("RA").InnerText + ".jpg";


              command.CommandText = "INSERT INTO alunos (ra, nome, turma, foto)" +
              "VALUES('" + ra + "','" + nome + "','" + turma + "','" + foto + "')";
              MySqlDataReader Query = command.ExecuteReader();

              connection.Close();
              
          }
          MessageBox.Show("Turma Importada com Sucesso!!!");
          puxarturmas();


      }

      private void cboturma_SelectedIndexChanged(object sender, EventArgs e)
      {

      }

      private void cboturmaexp_SelectedIndexChanged(object sender, EventArgs e)
      {
          cmdexport.Enabled = true;
      }

      private void cboturma_TextChanged(object sender, EventArgs e)
      {
          int cont = 0;
          int aux = 0;
          turma = cboturma.Text;

          while (cont <= cboturma.Items.Count - 1)
          {
              if (turma == cboturma.Items[cont].ToString())
                  aux++;

              cont++;
          }
          if (aux == 0)
              cmdaddturma.Enabled = true;
          else
              cmdaddturma.Enabled = false;
          turma = "";
      }

      private void tmrconf_Tick(object sender, EventArgs e)
      {
          if ((txtnome.Text.Trim() != "") && (txtra.Text.Trim() != "") && (cboturma.Text.Trim() != ""))
              cmdconfirma.Enabled = true;
          else
              cmdconfirma.Enabled = false;

          if(txtra.Text != "")
              cmdfoto.Enabled = true;
      }

    }
}

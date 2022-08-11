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
using System.IO;
namespace CodAlunos
{
    public partial class entrada : Form
    {
        
        public entrada()
        {
            InitializeComponent();
        }

        private void entrada_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtnum;
        }

        private void txtnum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                Seguranca seguranca = new Seguranca();

                string turma = "";
                string ra = "";
                string nome = "";
                int aux = 0;
                DateTime data2 = DateTime.Today;
                DateTime hora2 = DateTime.Now;
                string data = data2.ToShortDateString();
                string hora = hora2.ToShortTimeString().Substring(0, 5);



                string database = "SERVER=localhost;DATABASE=escola;UID=root;PASSWORD=;";
                MySqlConnection connection = new MySqlConnection(database);
                MySqlDataReader reader = null; ;  //conexão do BD
                MySqlCommand command = connection.CreateCommand();

                connection.Open();

                MySqlCommand cmd = new MySqlCommand("select * from alunos", connection);

                  //leitura do BD
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (txtnum.TextLength != 11)
                    {
                        lblerro.Visible = true;
                        lblcerto.Visible = false;
                        txtnum.Text = string.Empty;
                        aux = 2;
                        break;
                    }

                    //alterado 
                    if (seguranca.decripta(reader[0].ToString()) == seguranca.decripta(txtnum.Text)) //quando dá certo a leitura
                    {
                        
                        
                        aux = 1;

                        lblcerto.Visible = true;
                        lblerro.Visible = false;
                        lblra.Text = reader[0].ToString().Substring(0, 8);
                        lblnome.Text = reader[1].ToString();
                        imgaluno2.ImageLocation = reader[3].ToString();

                        ra = reader[0].ToString();
                        nome = reader[1].ToString();
                        turma = reader[2].ToString();
                        break;

                    }


                }

                reader.Close();

                if (aux == 1)
                {
                    command.CommandText = "INSERT INTO presenca (ra, nome, data, hora, turma)" + "VALUES('" + ra + "','" + nome + "','" + data + "','" + hora + "','" + turma + "')";
                    MySqlDataReader Query = command.ExecuteReader();
                }
                else if(aux == 0)
                {
                    lblerro.Visible = true;
                    lblcerto.Visible = false;
                    txtnum.Text = string.Empty;
                }

                aux = 0;
                connection.Close();

            }
        }

        private void tmr_Tick(object sender, EventArgs e)
        {

            lblcerto.Visible = false;
            lblerro.Visible = false;
            lblnome.Text = String.Empty;
            lblra.Text = String.Empty;
            imgaluno2.Image = null;

        }

        private void tmrtxt_Tick(object sender, EventArgs e)
        {
            txtnum.Text = string.Empty;
        }

        private void btnvolta_Click(object sender, EventArgs e)
        {
            this.Hide();
            var volta = new telainicial();
            volta.Closed += (s, args) => this.Close();
            volta.Show();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Inicio : Form
    {
        SqlConnection sqlcon = null;
        private string strcon = @"Data Source=(localdb)\MSSQLLOCALDB;Initial Catalog=BDtest;Integrated Security=True";
        private string strsql = String.Empty;
        private string strsql1 = String.Empty;

        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(strcon);
            string user, pwd;
            int nivel;

            try
            {
                user = txtLogin.Text;
                pwd = txtPass.Text;
                strsql = "SELECT COUNT(id) FROM utilizadores WHERE login = @utilizador AND pass = @chave";
                SqlCommand cmd = new SqlCommand(strsql, sqlcon);
                cmd.Parameters.Add("@utilizador", SqlDbType.VarChar).Value = user;
                cmd.Parameters.Add("@chave", SqlDbType.VarChar).Value = pwd;
                sqlcon.Open();

                int v = (int)cmd.ExecuteScalar();
                if (v > 0)
                {
                    strsql1 = "SELECT nivel FROM utilizadores WHERE login = @utilizador AND pass = @chave";
                    SqlCommand cmd1 = new SqlCommand(strsql1, sqlcon);
                    cmd1.Parameters.Add("@utilizador", SqlDbType.VarChar).Value = user;
                    cmd1.Parameters.Add("@chave", SqlDbType.VarChar).Value = pwd;
                    nivel = (int)cmd1.ExecuteScalar();
                    if (nivel == 0)
                    {
                        MessageBox.Show("Contacte o administrador seu nível de acesso ainda não foi alterado");
                    }
                    else if (nivel == 1)
                    {
                        GerirUtilizadores m = new GerirUtilizadores();
                        m.Show();
                    }
                }
                else
                {
                    MessageBox.Show("O Utilizador não se encontra registado");
                    RegistoUtilizador m = new RegistoUtilizador();
                    m.Show();
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro + "bd n existe");
            }
            finally 
            {
                sqlcon.Close();
            }
        
               
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

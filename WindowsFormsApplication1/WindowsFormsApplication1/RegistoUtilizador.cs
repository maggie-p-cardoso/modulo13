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
    public partial class RegistoUtilizador : Form
    {
        SqlConnection sqlcon = null;
        private string strcon = @"Data Source=(localdb)\MSSQLLOCALDB;Initial Catalog=BDtest;Integrated Security=True";
        private string strsql = String.Empty;

        public RegistoUtilizador()
        {
            InitializeComponent();
        }

        private void BtnRegistar_Click(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(strcon);

            try
            {

                strsql = "SELECT COUNT(id) FROM utilizadores WHERE login = '" + txtLogin.Text + "' ";
                SqlCommand cmd = new SqlCommand(strsql, sqlcon);
                sqlcon.Open();
                int v = (int)cmd.ExecuteScalar();
                if (v == 0) //se os registos forem = 0
                {
                    cmd = new SqlCommand();
                    cmd.Connection = sqlcon;
                    cmd.CommandText = @"INSERT INTO utilizadores ([nome], [e-mail], [data_nasc], [login], [pass], [nivel], [departamento]) VALUES (@nome, @p1, @data_nasc, @login, @pass, @nivel, @departamento);
SELECT id, nome, [e-mail], data_nasc, login, pass, nivel, departamento FROM Utilizadores WHERE (id = SCOPE_IDENTITY())";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@nome", SqlDbType.NVarChar).Value = txtNome.Text;
                    cmd.Parameters.Add("@p1", SqlDbType.NVarChar).Value = txtE_mail.Text;
                    cmd.Parameters.Add("@data_nasc", SqlDbType.Date).Value = dtpData_nasc.Value;
                    cmd.Parameters.Add("@login", SqlDbType.NVarChar).Value = txtLogin.Text;
                    cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = txtPass.Text;
                    cmd.Parameters.Add("@nivel", SqlDbType.Int, 0).Value = 0;
                    cmd.Parameters.Add("@departamento", SqlDbType.NVarChar).Value = txtDepartamento.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registo inserido com sucesso");
                }
                else
                {
                    MessageBox.Show("O registo já existe");
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

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PIMIII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bntEnviar_Click(object sender, EventArgs e)
        {

            //Instanciando o objeto conectar da classe SqlCOnnection para conectar ou banco de dados
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-GUPK5EL\\SQLEXPRESS;Initial Catalog=HotelVallhala;Integrated Security=True");

            try
            {

                //Instanciando o objeto c da classe SqlCommand que ira escrever um comando sql(inserto, select e etc)
                SqlCommand c = new SqlCommand("INSERT INTO hotel(estado, rua, bairro, complemento, cpf_gerente) VALUES(@estado, @rua, @bairro, @complemento, @cpf_gerente)", conectar);

                //Insere os dados da text box no comando sql
                c.Parameters.Add(new SqlParameter("@estado", this.txtEstado.Text));
                c.Parameters.Add(new SqlParameter("@rua", this.txtRua.Text));
                c.Parameters.Add(new SqlParameter("@bairro", this.txtBairro.Text));
                c.Parameters.Add(new SqlParameter("@complemento", this.txtComplemento.Text));
                c.Parameters.Add(new SqlParameter("@cpf_gerente", this.txtCpf.Text));

                //Conectar ao banco
                conectar.Open();

                //Comando para executar o INSERT
                c.ExecuteNonQuery();

                //Fecha a conecxão com o banco
                conectar.Close();

                MessageBox.Show("Enviado com sucesso");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro" + ex);
            }
            finally
            {
                conectar.Close();
            }
            

        }

    }
}

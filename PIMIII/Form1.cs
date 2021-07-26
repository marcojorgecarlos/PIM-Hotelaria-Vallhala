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
using System.Data.Sql;
using System.ComponentModel.DataAnnotations;

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

        private void bntEnviar_Click(object sender, EventArgs e)
        {
            Hotel hotel1 = new Hotel();

            string t = mtxtUf.Text;
          
            if (hotel1.validarUf(mtxtUf.Text) == 0)
            {
                MessageBox.Show("O uf está vazio ou faltando casas para serem preenchidas");
                mtxtUf.Text = "";
                return;
            }
            else if(hotel1.validarUf(mtxtUf.Text) == 2)
            {
                MessageBox.Show("O uf está incorreto");
                mtxtUf.Text = "";
                return;
            }
            
            if (hotel1.validarCpf(mtxtCpf.Text) == 0)
            {
                MessageBox.Show("Por favor digite um cpf valido");
                mtxtCpf.Text = "";
                return;
            }
            else if (hotel1.validarCpf(mtxtCpf.Text) == 2)
            {
                MessageBox.Show("O Cpf está vazio ou faltando casas para serem preenchidas");
                mtxtCpf.Text = "";
                return;
            }
            

            //Instanciando o objeto conectar da classe SqlCOnnection para conectar ou banco de dados
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-I1M48RU\\SQLEXPRESS;Initial Catalog=HotelVallhala;Integrated Security=True");

            try
            {

                //Instanciando o objeto c da classe SqlCommand que ira escrever um comando sql(inserto, select e etc)
                SqlCommand c = new SqlCommand("INSERT INTO info_hotel(uf_hotel, cidade_hotel, rua_hotel, numero_hotel, bairro_hotel, telefone, cpf_responsavel) VALUES(@uf, @cidade, @rua, @numero, @bairro, @telefone, @cpf)", conectar);

                //Insere os dados da text box no comando sql
                c.Parameters.Add(new SqlParameter("@uf", this.mtxtUf.Text));
                c.Parameters.Add(new SqlParameter("@cidade", this.mtxtCidade.Text));
                c.Parameters.Add(new SqlParameter("@rua", this.mtxtRua.Text));
                c.Parameters.Add(new SqlParameter("@numero", this.mtxtNumero.Text));
                c.Parameters.Add(new SqlParameter("@bairro", this.mtxtCpf.Text));
                c.Parameters.Add(new SqlParameter("@telefone", this.mtxtTelefone.Text));
                c.Parameters.Add(new SqlParameter("@cpf", this.mtxtCpf.Text));

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

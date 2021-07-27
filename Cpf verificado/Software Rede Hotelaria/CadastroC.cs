using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Software_Rede_Hotelaria
{
    public partial class CadastroC : Form
    {
        public CadastroC()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CadastroC_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-D83UVNJ\\SQLEXPRESS;Initial Catalog=FUNCIONARIOS;Integrated Security=True");
            string sql = "INSERT INTO CLIENTE(NOME_C, NOMESOCIAL, CPF_C, RG_C, DTNASC_C, SEXO_C, EMAIL_C, TEL_C, CIDADE_C, ESTADO_C, RUA_C, NUM_C, BAIRRO_C) " +
                "VALUES (@NOME_C, @NOMESOCIAL, @CPF_C, @RG_C, @DTNASC_C, @SEXO_C, @EMAIL_C, @TEL_C, @CIDADE_C, @ESTADO_C, @RUA_C, @NUM_C, @BAIRRO_C)";

            try
            {
                SqlCommand c = new SqlCommand(sql, conn);

                c.Parameters.Add(new SqlParameter("@NOME_C", this.TxtNomeC.Text));
                c.Parameters.Add(new SqlParameter("@NOMESOCIAL", this.TxtNomeSC.Text));
                c.Parameters.Add(new SqlParameter("@CPF_C", this.TxtCpfC.Text));
                c.Parameters.Add(new SqlParameter("@RG_C", this.TxtRgC.Text));
                c.Parameters.Add(new SqlParameter("@DTNASC_C", this.TxtDtNasc.Text));
                c.Parameters.Add(new SqlParameter("@SEXO_C", this.TxtSexoC.Text));
                c.Parameters.Add(new SqlParameter("@EMAIL_C", this.TxtEmailC.Text));
                c.Parameters.Add(new SqlParameter("@TEL_C", this.TxtTelC.Text));
                c.Parameters.Add(new SqlParameter("@CIDADE_C", this.TxtCidadeC.Text));
                c.Parameters.Add(new SqlParameter("@ESTADO_C", this.TxtEstadoC.Text));
                c.Parameters.Add(new SqlParameter("@RUA_C", this.TxtRuaC.Text));
                c.Parameters.Add(new SqlParameter("@NUM_C", this.TxtNumC.Text));
                c.Parameters.Add(new SqlParameter("@BAIRRO_C", this.TxtBairroC.Text));

                conn.Open();
                c.ExecuteNonQuery();
                conn.Close();


                MessageBox.Show("Cadastrado com sucesso!");
                this.Close();
                Home voltar = new Home();
                voltar.Show();
                
            } catch(SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro: " + ex);
            }
            finally
            {
                conn.Close();
            }

         }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home voltar = new Home();
            voltar.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

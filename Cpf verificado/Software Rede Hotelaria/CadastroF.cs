using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Software_Rede_Hotelaria
{
    public partial class CadastroF : Form
    {
        public CadastroF()
        {
            InitializeComponent();
        }

        public string func_uf;

        public int validarUf(string txt_uf)
        {
            if (txt_uf != "RO" || txt_uf != "AC" || txt_uf != "AM" || txt_uf != "RR" || txt_uf != "AP" || txt_uf != "PA" || txt_uf != "TO" || txt_uf != "MA"
               || txt_uf != "PI" || txt_uf != "CE" || txt_uf != "RN" || txt_uf != "PB" || txt_uf != "PE" || txt_uf != "AL" || txt_uf != "SE" || txt_uf != "BA"
                || txt_uf != "MG" || txt_uf != "ES" || txt_uf != "RJ" || txt_uf != "SP" || txt_uf != "SC" || txt_uf != "PR" || txt_uf != "RS" || txt_uf != "MS"
                 || txt_uf != "MT" || txt_uf != "Go" || txt_uf != "DF")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public string testecpf(string txt)
        {
            return txt;
        }

        public int validarcpf(string txt_cpf)
        {
            int[] cpf = new int[11];
            int soma_cpf = 0;
            int[] digito = new int[2];
            string text = txt_cpf;
            char[] letra = new char[11];

            letra[0] = text[0];
            letra[1] = text[1];
            letra[2] = text[2];
            letra[3] = text[3];
            letra[4] = text[4];
            letra[5] = text[5];
            letra[6] = text[6];
            letra[7] = text[7];
            letra[8] = text[8];
            letra[9] = text[9];
            letra[10] = text[10];

            cpf[0] = int.Parse(letra[0].ToString());
            cpf[1] = int.Parse(letra[1].ToString());
            cpf[2] = int.Parse(letra[2].ToString());
            cpf[3] = int.Parse(letra[3].ToString());
            cpf[4] = int.Parse(letra[4].ToString());
            cpf[5] = int.Parse(letra[5].ToString());
            cpf[6] = int.Parse(letra[6].ToString());
            cpf[7] = int.Parse(letra[7].ToString());
            cpf[8] = int.Parse(letra[8].ToString());
            cpf[9] = int.Parse(letra[9].ToString());
            cpf[10] = int.Parse(letra[10].ToString());

            int controle = 10;
            for (int i =0; i <= 8; i++)
            {
                soma_cpf += cpf[i] * controle;
                controle--;
            }

            if((soma_cpf % 11) > 2)
            {
                digito[0] = 11 - (soma_cpf % 11);
            }
            else
            {
                digito[0] = 0;
            }
            controle = 11;
            soma_cpf = 0;

            for(int i = 0; i <= 9; i++)
            {
                soma_cpf += cpf[i] * controle;
                controle--;
            }

            if ((soma_cpf % 11) > 2)
            {
                digito[1] = 11 - (soma_cpf % 11);
            }
            else
            {
                digito[1] = 0;
            }
            
            if (cpf[9] == digito[0])
            {
                if(cpf[10] == digito[1])
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastroF_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-D83UVNJ\\SQLEXPRESS;Initial Catalog=FUNCIONARIOS;Integrated Security=True");

            string sql = "INSERT INTO DADOS_FUNCIONARIOS(NOME, CPF, RG, SEXO, ESTADO_CIVIL, EMAIL, TELEFONE, ESTADO, CIDADE, RUA, NUMERO, SALARIO, CARGO) " +
                "VALUES (@NOME, @CPF, @RG, @SEXO, @ESTADO_CIVIL, @EMAIL, @TELEFONE, @ESTADO, @CIDADE, @RUA, @NUMERO, @SALARIO, @CARGO)";

            //Random numeroID = new Random();
            //numeroID.Next();

            try
            {
                SqlCommand c = new SqlCommand(sql, conn);

               
                c.Parameters.Add(new SqlParameter("@NOME", this.TxtNome.Text));
                c.Parameters.Add(new SqlParameter("@CPF", this.TxtCpf.Text));
                c.Parameters.Add(new SqlParameter("@RG", this.TxtRg.Text));
                c.Parameters.Add(new SqlParameter("@SEXO", this.TxtSexo.Text));
                c.Parameters.Add(new SqlParameter("@ESTADO_CIVIL", this.TxtEstC.Text));
                c.Parameters.Add(new SqlParameter("@EMAIL", this.TxtEmail.Text));
                c.Parameters.Add(new SqlParameter("@TELEFONE", this.TxtTelefone.Text));
                c.Parameters.Add(new SqlParameter("@ESTADO", this.TxtEstado.Text));
                c.Parameters.Add(new SqlParameter("@CIDADE", this.TxtCidade.Text));
                c.Parameters.Add(new SqlParameter("@RUA", this.TxtRua.Text));
                c.Parameters.Add(new SqlParameter("@NUMERO", this.TxtNum.Text));
                c.Parameters.Add(new SqlParameter("@SALARIO", this.TxtSal.Text));
                c.Parameters.Add(new SqlParameter("@CARGO", this.TxtCargo.Text));

                conn.Open();

                c.ExecuteNonQuery();

                conn.Close();

            MessageBox.Show("Cadastrado com sucesso!");
            this.Close();
            OpADM admt = new OpADM();
            admt.Show();

            }catch(SqlException ex)
            {
                MessageBox.Show("Ocorreu o Erro: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpADM admt = new OpADM();
            admt.Show();
            this.Close();
        }
    }
}

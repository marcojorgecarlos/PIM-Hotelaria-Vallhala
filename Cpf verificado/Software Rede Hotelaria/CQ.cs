using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Software_Rede_Hotelaria
{
    public partial class CQ : Form
    {
        public CQ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-D83UVNJ\\SQLEXPRESS;Initial Catalog=FUNCIONARIOS;Integrated Security=True");
            string sql = "INSERT INTO QUARTO (FG_RESERVADO, ID_HOTEL, TIPO_QUARTO, ANDAR_QUARTO, NMR_QUARTO, LIMITE_PES, VALOR_DIARIA) " +
                "VALUES (@FG_RESERVADO, @ID_HOTEL, @TIPO_QUARTO, @ANDAR_QUARTO, @NMR_QUARTO, @LIMITE_PES, @VALOR_DIARIA)";

            try
            {
                SqlCommand c = new SqlCommand(sql, conn);

                c.Parameters.Add(new SqlParameter("@FG_RESERVADO", this.TxtFg.Text));
                c.Parameters.Add(new SqlParameter("@ID_HOTEL", this.TxtId.Text));
                c.Parameters.Add(new SqlParameter("@TIPO_QUARTO", this.TxtTipo.Text));
                c.Parameters.Add(new SqlParameter("@ANDAR_QUARTO", this.TxtAndar.Text));
                c.Parameters.Add(new SqlParameter("@NMR_QUARTO", this.TxtNmr.Text));
                c.Parameters.Add(new SqlParameter("@LIMITE_PES", this.TxtLim.Text));
                c.Parameters.Add(new SqlParameter("@VALOR_DIARIA", this.TxtVal.Text));

                conn.Open();
                c.ExecuteNonQuery();
                conn.Close();

            MessageBox.Show("Cadastrado com sucesso!");
            this.Close();
            OpADM admt = new OpADM();
            admt.Show();

            } catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro: " + ex);
            }
            finally
            {
                conn.Close();
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            OpADM admt = new OpADM();
            admt.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMIII.classes
{
    class ComandoSql
    {
        public bool validacao = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool pesquisarLogin(String login, String senha)
        {
            cmd.CommandText = "select * from Logins where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("senha", senha);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    validacao = true;
                }
                else
                {
                    validacao = false;
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }
            return validacao;
        }

        public bool inserirHotel (String cpfGerente, String uf, String cidade, String rua, String numero, String bairro, String telefone)
        {
            cmd.CommandText = "insert into info_hotel(uf_hotel, cidade_hotel, rua_hotel, numero_hotel, bairro_hotel, telefone, cpf_responsavel) VALUES(@uf, @cidade, @rua, @numero, @bairro, @telefone, @cpf)";
            cmd.Parameters.AddWithValue("@uf", uf);
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@rua", rua);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@bairro", bairro);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("cpf", cpfGerente);

            try
            {

                con.Conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                validacao = true;
            }
            catch(SqlException ex)
            {
                this.mensagem = "Erro com banco de dados" + ex;
                validacao = false;
            }
            return validacao;
        }
    }
}

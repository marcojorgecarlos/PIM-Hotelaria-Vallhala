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
        public bool tem = false;
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
                    tem = true;
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }
            return tem;
        }

        
    }
}

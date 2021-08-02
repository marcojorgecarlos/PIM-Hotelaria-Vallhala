using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMIII.classes
{
    public class Controle
    {
        public bool vrLogin;
        public bool vrCpf;
        public String mensagem = "";
        ComandoSql comandosql = new ComandoSql();

        public bool controleLogin(String Login, String Senha)
        {
            vrLogin = comandosql.pesquisarLogin(Login, Senha);
            if (!comandosql.mensagem.Equals(""))
            {
                this.mensagem = comandosql.mensagem;
            }
            return vrLogin;
        }

        public bool controleCpf(String cpf)
        {
            Hotel verificacao = new Hotel();
            vrCpf = verificacao.validarCpf(cpf);
            if (!comandosql.mensagem.Equals(""))
            {
                this.mensagem = comandosql.mensagem;
            }
            return vrCpf;
        }
    }
}

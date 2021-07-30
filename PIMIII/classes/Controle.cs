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

        public bool controleLogin(String Login, String Senha)
        {
            ComandoSql comando = new ComandoSql();
            vrLogin = comando.pesquisarLogin(Login, Senha);
            if (!comando.mensagem.Equals(""))
            {
                this.mensagem = comando.mensagem;
            }
            return vrLogin;
        }

        public bool controleCpf(String cpf)
        {
            Hotel verificacao = new Hotel();
            vrCpf = verificacao.validarCpf(cpf);
            return vrCpf;
        }
    }
}

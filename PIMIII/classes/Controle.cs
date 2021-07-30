using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMIII.classes
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";

        public bool controleLogin(String Login, String Senha)
        {
            ComandoSql comando = new ComandoSql();
            tem = comando.pesquisarLogin(Login, Senha);
            if (!comando.mensagem.Equals(""))
            {
                this.mensagem = comando.mensagem;
            }
            return tem;
        }
    }
}

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
            ComandoSql comandosql = new ComandoSql();
            vrLogin = comandosql.pesquisarLogin(Login, Senha);
            if (!comandosql.mensagem.Equals(""))
            {
                this.mensagem = comandosql.mensagem;
            }
            return vrLogin;
        }

        public void validarHotel(String cpfGerente, String uf, String cidade, String rua, String numero, String bairro, String telefone)
        {
            Hotel verificacao = new Hotel();

            verificacao.validarTelefone(telefone);
            if (!verificacao.mensagem.Equals(""))
            {
                this.mensagem = verificacao.mensagem;
                return;
            }
            verificacao.validarCpf(cpfGerente);
            if (!verificacao.mensagem.Equals(""))
            {
                this.mensagem = verificacao.mensagem;
            }
            verificacao.validarBairro(bairro);
            if (!verificacao.mensagem.Equals(""))
            {
                this.mensagem = verificacao.mensagem;
                return;
            }
            verificacao.validarCidade(cidade);
            if (!verificacao.mensagem.Equals(""))
            {
                this.mensagem = verificacao.mensagem;
                return;
            }
            verificacao.validarNumero(numero);
            if (!verificacao.mensagem.Equals(""))
            {
                this.mensagem = verificacao.mensagem;
                return;
            }
            verificacao.validarRua(rua);
            if (!verificacao.mensagem.Equals(""))
            {
                this.mensagem = verificacao.mensagem;
                return;
            }
            verificacao.validarUf(uf);
            if (!verificacao.mensagem.Equals(""))
            {
                this.mensagem = verificacao.mensagem;
            }
           
        }
    }
}

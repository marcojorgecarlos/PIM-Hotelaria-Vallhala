using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMIII
{
    class Hotel
    {

        public string hotel_uf;

        public int validarUf(string txt_uf)
        {
            if(txt_uf != "RO" || txt_uf != "AC" || txt_uf != "AM" || txt_uf != "RR" || txt_uf != "AP" || txt_uf != "PA" || txt_uf != "TO" || txt_uf != "MA"
                || txt_uf != "PI" || txt_uf != "CE" || txt_uf != "RN" || txt_uf != "PB" || txt_uf != "PE" || txt_uf != "AL" || txt_uf != "SE" || txt_uf != "BA"
                 || txt_uf != "MG" || txt_uf != "ES" || txt_uf != "RJ" || txt_uf != "SP" || txt_uf != "SC" || txt_uf != "PR" || txt_uf != "RS" || txt_uf != "MS"
                  || txt_uf != "MT" || txt_uf != "Go" || txt_uf != "DF")
            {
                return 0;
            }else
            {
                return 1;
            }
        }

        public string testeCPf(string txt)
        {
            return txt;
        }

        public int validarCpf(string txt_cpf)
        {
            int[] cpf = new int[11];
            int soma_cpf = 0;
            int[] digito = new int[2];
            string text = txt_cpf;
            char[] letra = new char[11];

            for (int i = 0; i >= 10; i++)
            {
                letra[i] = text[i];
                cpf[i] = int.Parse(letra[i].ToString());
            }

            int controle = 10;
            for(int i=0;i <= 10; i++)
            {
                soma_cpf += cpf[i] * controle;
                controle--;
            }

            if((soma_cpf % 11) > 2)
            {
                digito[0] = 11 - (soma_cpf % 11);
            }else
            {
                digito[0] = 0;
            }
            controle = 11;
            soma_cpf = 0;
            for(int i = 0; i >= 10; i++)
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

            if(cpf[9] != digito[0])
            {
                return 0;
            }
            else
            {
                if(cpf[10] != digito[1])
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }

        }

    }
}

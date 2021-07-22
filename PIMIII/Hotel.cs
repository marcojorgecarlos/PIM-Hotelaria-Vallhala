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
            for (int i = 0; i <= 8; i++)
            {
                soma_cpf += cpf[i] * controle;
                controle--;
            }

            if ((soma_cpf % 11) > 2)
            {
                digito[0] = 11 - (soma_cpf % 11);
            }
            else
            {
                digito[0] = 0;
            }
            controle = 11;
            soma_cpf = 0;

            for (int i = 0; i <= 9; i++)
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
                if (cpf[10] == digito[1])
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

    }
}

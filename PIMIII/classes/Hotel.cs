﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMIII
{
    class Hotel
    {

        public int validarNumero(string txt_Numero)
        {
            if (txt_Numero.Length == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public int validarTelefone(string txt_Telefone)
        {
            if(txt_Telefone.Length <= 10)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public int validarCidade(string txt_Cidade)
        {
            if (txt_Cidade.Length <= 2)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public int validarBairro(string txt_bairro)
        {
            if(txt_bairro.Length <= 4)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public int validarRua(string txt_rua)
        {
            if(txt_rua.Length <= 4)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public int validarUf(string txt_uf)
        {
            string t = txt_uf;

            if (t.Length <= 1)
            {
                return 0;
            }
            

            if (t == "RO" || t == "AC" || t == "AM" || t == "RR" || t == "AP" || t == "PA" || t == "TO" || t == "MA"
                || t == "PI" || t == "CE" || t == "RN" || t == "PB" || t == "PE" || t == "AL" || t == "SE" || t == "BA"
                 || t == "MG" || t == "ES" || t == "RJ" || t == "SP" || t == "SC" || t == "PR" || t == "RS" || t == "MS"
                  || t == "MT" || t == "Go" || t == "DF")
            {
                
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public int validarCpf(string txt_cpf)
        {
            int[] cpf = new int[11];
            int soma_cpf = 0;
            int[] digito = new int[2];
            string text = txt_cpf;
            char[] letra = new char[11];

            if(text.Length <= 10)
            {
                return 2;
            }

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
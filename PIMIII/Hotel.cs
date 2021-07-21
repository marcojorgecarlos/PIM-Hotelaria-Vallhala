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

    }
}

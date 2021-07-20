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

        public int hotel_id { get; set; }

        [Required]
        [MaxLength(2)]
        public string hotel_uf { get; set; }

        [Required]
        public string hotel_cidade { get; set; }

        [Required]
        public string hotel_rua { get; set; }

        [Required]
        public string hotel_numerpo { get; set; }

        [Required]
        public string hotel_bairro { get; set; }

        [Required]
        [Phone]
        public int hotel_telefone { get; set; }

        [Required]
        [MaxLength(11)]
        public string cpf_gerente { get; set; }

    }
}

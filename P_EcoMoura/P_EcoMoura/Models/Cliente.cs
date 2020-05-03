using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace P_EcoMoura.Models
{
    public class Cliente
    {
        /* PK */
        public int id { get; set; }

        public int? idEmpresa { get; set; }

        [ForeignKey("idEmpresa")]
        public virtual Cliente Empresa { get; set; }

        public string razaoSocial { get; set; }

        public string cnpj { get; set; }

        public string telefone { get; set; }

        public string celular { get; set; }

        public decimal saldoBIN { get; set; }

        public int? idRota { get; set; }

        [ForeignKey("idRota")]
        public virtual Cliente Rota { get; set; }

        public byte situacao { get; set; }

        

        

    }
}

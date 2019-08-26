using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aula06.fiap.Models
{
    public class Sorvete
    {
        public string Nome { get; set; }

        [Display(Name = "Data de Vencimento"),DataType(DataType.Date)]
        public DateTime DataVencimento { get; set; }
        public bool Vegano { get; set; }
        public Tipo TipoSorvete { get; set; }
    }
}

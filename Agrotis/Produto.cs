using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrotis
{
    public class Produto
    {
        [Key]
        public int codigo_produto { get; set; }
        public string descricao { get; set; }
        public decimal peso_liquido { get; set; }
        public decimal preco_unitario { get; set; }
        
    }
}

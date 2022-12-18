using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrotis
{
    public class Pedido
    {
        [Key]
        public int codigo_pedido { get; set; }
        public int codigo_cliente { get; set; }
        public string nome_cliente { get; set; }
        public Decimal preco_pedido { get; set; }
        public Decimal peso_pedido { get; set; }
        public DateTime emissao { get; set; }
    
    }
}

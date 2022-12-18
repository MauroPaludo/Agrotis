using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrotis
{
    public class ItensPedido
    {
        [Key]
        public int codigo_itenspedido { get; set; }
        public int codigo_pedido { get; set; }
        public int codigo_produto { get; set; }
        public Decimal quantidade { get; set; }
        public Decimal preco_unitario { get; set; }
        public Decimal peso_liquido { get; set; }
        public Decimal preco_total { get; set; }
        public Decimal peso_total { get; set; }
    }
}

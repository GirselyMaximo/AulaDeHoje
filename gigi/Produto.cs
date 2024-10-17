using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gigi
{
    public class Produto
    {
        public  int Id {  get; set; }

        [DisplayName("Produto")]
        public string Name { get; set; }
        public string Fabricante { get; set; }
        [DisplayName("Preço de compra")]
        public decimal PrecoCompra {  get; set; }
        [DisplayName("Preço de Venda")]
        public decimal PrecoVenda { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gigi
{
    public class Venda
    {
        public int id {  get; set; }
        [DisplayName("Id do Produto")] public int idProduto { get; set; }
        [DisplayName("Id do cliente")] public int idCliente { get; set; }
        [DisplayName("Quantidade Vendida")] public int quantidade { get; set; }
        [DisplayName("Porcentagem de descontp")] public float desconto { get; set; }
    }
}

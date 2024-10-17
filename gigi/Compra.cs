using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gigi
{
    public class Compra
    {
        public int id {  get; set; }
        [DisplayName("Id do Produto")] public int idProduto { get; set; }
        [DisplayName("Id do fornecedor")] public int idFornecedor { get; set; }
        [DisplayName("Quantidade comprada")] public int quantidade { get; set; }
        [DisplayName("Porcentagem de descontp")] public float desconto { get; set; }

    }
}

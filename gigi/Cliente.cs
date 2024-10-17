using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gigi
{
    public class Cliente
    {
        [DisplayName("Id")] public int id { get; set; }
        [DisplayName("Nome do cliente")] public string nome { get; set; }
        [DisplayName("Número de Telefone")] public string fone { get; set; }
        [DisplayName("Endereço de E-mail")] public string email { get; set; }
        [DisplayName("Endereço Físico")] public string endereço { get; set; }
    }
}


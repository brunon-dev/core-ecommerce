using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using loja.Models;

namespace loja.Interfaces
{
    public interface IPedidoRepository
    {
        Pedido GetPedido();
        void AddItem(string codigo);
    }
}

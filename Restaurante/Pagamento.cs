using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    public class Pagamento
    {
        public decimal ValorPago { get; set; }

        public void RealizarPagamento(decimal valor, decimal totalPedido)
        {
            if (valor <= 0)
            {
                Console.WriteLine($"Valor é insuficiente para pagamento");
                Logger.Log($"Valor é insuficiente para pagamento");
                return;
            }
            
            if (valor >= totalPedido)
            {
                ValorPago = valor;
                Console.WriteLine($"Pagamento de R${ValorPago} realizado com sucesso! Troco R${valor - totalPedido}");
                Logger.Log($"Pagamento de R${ValorPago} realizado com sucesso! Troco R${valor - totalPedido}");
            }

            else
            {
                Console.WriteLine("Valor insuficiente para cobrir o total do pedido.");
                Logger.Log("Valor insuficiente para cobrir o total do pedido.");
            }
        }
    }
}

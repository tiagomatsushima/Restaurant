using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    public class Pedido
    {
        private List<ItemMenu> Itens { get; set; } = new List<ItemMenu>();

        public void AdicionarItem(ItemMenu item)
        {
            Itens.Add(item);
            Logger.Log($"{item.Nome} adicionado ao pedido.");
        }
        public void RemoverItem(ItemMenu item)
        {
            if (Itens.Contains(item))
            {
                Itens.Remove(item);
                Logger.Log($"{item.Nome} adicionado ao pedido.");
            }
            else
            {
                Console.WriteLine($"{item.Nome} não está no pedido");
                Logger.Log($"{item.Nome} não está no pedido");
            }

            
        }
        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var item in Itens)
            {
                total += item.Preco;
            }
            return total;
        }
        public void ExibirPedido()
        {
            Console.WriteLine("Detalhes do Pedido");
            foreach (var item in Itens)
            {
                item.ExibirDetalhes();
            }
            Console.WriteLine($"Total: R$ {CalcularTotal()}");
            Logger.Log($"Total: R$ {CalcularTotal()}");
        }
    }
}

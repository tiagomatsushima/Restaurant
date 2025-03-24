using Restaurante.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    public abstract class ItemMenu : IItemMenu
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public ItemMenu(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public abstract void ExibirDetalhes();
    }
}

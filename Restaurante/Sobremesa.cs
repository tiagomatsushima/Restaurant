using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    public class Sobremesa : ItemMenu
    {
        public bool Gluten { get; set; }
        public Sobremesa(string nome, decimal preco, bool gluten) : base(nome, preco)
        {
            Gluten = gluten;
        }
        public override void ExibirDetalhes()
        {
            Console.WriteLine($"{Nome} - R${Preco} - Gluten: {(Gluten ? "Sim" : "Não")}");
        }
    }
}

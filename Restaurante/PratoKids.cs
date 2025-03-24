using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    public class PratoKids : ItemMenu
    {

        public bool Brinde { get; set; }

        public PratoKids(string nome, decimal preco, bool brinde) : base(nome, preco)
        {
            Brinde = brinde;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"{Nome} - R${Preco.ToString("N2", new CultureInfo("pt-BR"))} - Brinde: {(Brinde ? "Sim" : "Não")}");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    public class Comida : ItemMenu
    {
        public bool Vegano { get; set; }

        public Comida(string nome, decimal preco, bool vegano) : base(nome, preco)
        {
            Vegano = vegano;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"{Nome} - R${Preco.ToString("N2", new CultureInfo("pt-BR"))} - Vegano: {(Vegano ? "Sim" : "Não")}");
        }
    }
}

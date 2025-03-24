using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    public class Bebida : ItemMenu
    {
        public bool Alcoolico { get; set; }

        public Bebida(string nome, decimal preco, bool alcoolico) : base(nome, preco)
        {
            Alcoolico = alcoolico;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"{Nome} - R${Preco.ToString("N2", new CultureInfo("pt-BR"))} - Alcoólica: {(Alcoolico ? "Sim" : "Não")}");
        }
    }
}

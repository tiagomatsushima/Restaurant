using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    public class Promocao
    {
        public decimal PercentualDesconto { get; private set; }

        public Promocao(decimal percentualDesconto)
        {
            PercentualDesconto = percentualDesconto;
        }

        public void AplicarDesconto(ItemMenu itemMenu)
        {
            if (PercentualDesconto > 0 && PercentualDesconto < 100)
            {
                decimal desconto = itemMenu.Preco * (PercentualDesconto / 100);
                itemMenu.Preco -= desconto; //itemMenu.Preco = itemMenu.Preco - desconto
                Console.WriteLine($"{itemMenu.Nome} com desconto de {PercentualDesconto}% aplicado. Novo preço: R${itemMenu.Preco.ToString("N2", new CultureInfo("pt-BR"))}");
                Logger.Log($"{itemMenu.Nome} com desconto de {PercentualDesconto}% aplicado. Novo preço: R${itemMenu.Preco.ToString("N2", new CultureInfo("pt-BR"))}");
            }
            else
            {
                Console.WriteLine("Valor de desconto inválido.");
                Logger.Log("Valor de desconto inválido.");
            }
        }
    }
}

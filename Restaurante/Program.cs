using Restaurante;

//Criando items de comida e bebida

Comida pizza = new Comida("Pizza Marguerita", 25.00m, false);
Bebida cerveja = new Bebida("Cerveja Império", 6.50m, true);
Sobremesa sobremesa = new Sobremesa("Torta Alemã", 7.50m, true);
PratoKids pratoKids = new PratoKids("Fritas com Nuggets", 22.50m, false);
Entrada entrada = new Entrada("Salada Caesar", 15.00m, true);

//Criando a promoção de 10%
Promocao promocao = new Promocao(10.0m);
promocao.AplicarDesconto(entrada);
promocao.AplicarDesconto(pratoKids);

//Criando um pedido e adicionando itens

Pedido pedido = new Pedido();
pedido.AdicionarItem(pizza);
pedido.AdicionarItem(cerveja);
pedido.AdicionarItem(cerveja);
pedido.AdicionarItem(pratoKids);
pedido.AdicionarItem(sobremesa);
pedido.AdicionarItem(entrada);

//Exibindo os detalhes do pedido e o valor total

pedido.ExibirPedido();

//Realizando o pagamento

Pagamento pagamento = new Pagamento();
pagamento.RealizarPagamento(150.50m, pedido.CalcularTotal());


//Classe ItemMenu (classe base) = OK

//Classe Comida : ItemMenu = OK

//Classe Bebida : ItemMenu = OK

//Classe Pedido (Compor um pedido com ItemMenu) = OK

//Classe Pagamento(Realizar pagto) = OK

//Continuar a partir da implementação dos Logs




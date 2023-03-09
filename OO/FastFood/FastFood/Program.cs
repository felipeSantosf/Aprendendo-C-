using FastFood.Cliente;
using FastFood.Item;

Cliente cliente = new Cliente();
cliente.setNomeCliente("Felipe Jujuba");
cliente.setCpfCliente("123456789-56");
cliente.setCEPCliente("13216000");
cliente.setRuaCliente("Avenida São João");
cliente.setNumeroCliente(4562);
cliente.setBairroCliente("Vila Joana");
cliente.setCidadeCliente("Jundiaí");
cliente.setEstadoCliente("São Paulo");

Hamburguer hamburguer1 = new Hamburguer();
hamburguer1.setNome("Hambugão da tia Lena");
hamburguer1.setValor(54.55);
hamburguer1.setPercentualDesconto(5);
hamburguer1.adicionarProduto();
hamburguer1.adicionarProduto();
hamburguer1.adicionarProduto();

cliente.hamburguer = hamburguer1;
cliente.exibirCliente();
Console.WriteLine("\n\n");
hamburguer1.exibirProduto();
Console.WriteLine("\n\n");
hamburguer1.obterValor();
Console.WriteLine("\n\n");
hamburguer1.removerProduto();
hamburguer1.obterValor();



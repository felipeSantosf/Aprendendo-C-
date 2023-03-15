using ModuloCliente;

Cliente cliente = new Cliente();
cliente.Nome = "João Felicio";
cliente.Email = "joaoFelicio@gmail.com";
cliente.Cpf = "754839045";
cliente.Idade = 43;


Console.WriteLine(cliente.Nome);
Console.WriteLine(cliente.Email);
Console.WriteLine(cliente.Cpf);
Console.WriteLine(cliente.Idade);
Console.WriteLine(cliente);



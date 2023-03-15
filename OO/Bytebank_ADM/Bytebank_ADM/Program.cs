
using Bytebank_ADM.Funcionarios;
using Bytebank_ADM.Parceria;
using Bytebank_ADM.SistemaInterno;
using Bytebank_ADM.Utilitario;

#region
//Funcionario pedro = new Funcionario("123456789" , 2000);
//pedro.Nome = "Pedro João";

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor Ana = new Diretor("745893023", 5000);
//Ana.Nome = "Roberta Silva";

//Console.WriteLine(Ana.Nome);
//Console.WriteLine(Ana.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(Ana);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalBonificacoes);

//gerenciador.RegistrarPremiacaoSemestral(pedro);
//gerenciador.RegistrarPremiacaoSemestral(Ana);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalBonificacoes);
//Console.WriteLine("Total de funcionários: " + Funcionario.totalFuncionario);

//pedro.AumentarSalario();
//Ana.AumentarSalario();

//Console.WriteLine("Novo salario do Pedro: " + pedro.Salario);
//Console.WriteLine("Novo salario da Ana: " + Ana.Salario);
#endregion

void exibirTotalBonificacoes()
{
    //IGerenciadorDeBonificacao gerenciador = new IGerenciadorDeBonificacao();

    Auxiliar joao = new Auxiliar("20649334", 2000);
    joao.Nome = "João Neves";

    Designer juliana = new Designer("237856526", 3000);
    juliana.Nome = "Juliana Pereira";

    GerenteDeContas pedro = new GerenteDeContas("56890423", 4000);
    pedro.Nome = "Pedro Lucio";

    Diretor mariana = new Diretor("24359832", 5000);
    mariana.Nome = "Mariana Silva";

    //gerenciador.Registrar(joao);
    //gerenciador.Registrar(juliana);
    //gerenciador.Registrar(pedro);
    //gerenciador.Registrar(mariana);



    //Console.WriteLine("Total de bonificações: " + gerenciador.TotalBonificacoes);
}

exibirTotalBonificacoes();

void Autenticar()
{
    SistemaInterno sistema = new SistemaInterno();
    Diretor felipe = new Diretor("4568798", 5456.66);
    felipe.Login = "felipfe";
    felipe.Senha = "48376";
    sistema.logar(felipe, "felipe", "48376");

    GerenteDeContas pedro = new GerenteDeContas("38490453", 1098.44);
    pedro.Login = "pedro";
    pedro.Senha = "3223";
    sistema.logar(pedro, "pedro", "wewe");

    ParceiroComercial caio = new ParceiroComercial();
    caio.Login = "caio";
    caio.Senha = "4367";
    sistema.logar(caio, "caio", "4367");
}

Autenticar();

    
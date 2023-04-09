using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_ATENDIMENTO.bytebank.Exceptions;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Collections;
using System.Security.AccessControl;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

new ByteBankAtendimento().AtendimentoCliente();

#region exemplos Arrays em C#
//Array amostra = Array.CreateInstance(typeof(double), 5);
//amostra.SetValue(5.9, 0);
//amostra.SetValue(9, 1);
//amostra.SetValue(4, 2);
//amostra.SetValue(5, 3);
//amostra.SetValue(7, 4);

//void TestaMediana(Array array)
//{
//    if (array == null || array.Length == 0)
//    {
//        Console.WriteLine("Array para cálculo da mediana nulo ou vazio.");

//    }

//    double[] numerosOrdenados = (double[])array.Clone();
//    Array.Sort(array, numerosOrdenados);

//    int tamanho = numerosOrdenados.Length;
//    int meio = tamanho / 2;
//    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
//                                          (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
//    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
//}

////testaMediana(amostra);


//void TestaArrayDeContasCorrentes()
//{
//    ContaCorrente[] listaDeContas = new ContaCorrente[]
//    {
//        new ContaCorrente(874),
//        new ContaCorrente(874),
//        new ContaCorrente(874)
//    };

//    for (int i = 0; i < listaDeContas.Length; i++)
//    {
//        ContaCorrente contaAtual = listaDeContas[i];
//        Console.WriteLine($"Índice {i} - {contaAtual.ToString()}");
//    }

//}

//TestaArrayDeContasCorrentes();

//void TestaListaArrayDeContasCorrentes()
//{
//    ListaDeContaCorrente lista = new ListaDeContaCorrente(5);
//    lista.Adicionar(new ContaCorrente(321));
//    lista.Adicionar(new ContaCorrente(322));
//    lista.Adicionar(new ContaCorrente(323));
//    lista.Adicionar(new ContaCorrente(324));
//    lista.Adicionar(new ContaCorrente(325));
//    lista.Adicionar(new ContaCorrente(326));
//}

//TestaListaArrayDeContasCorrentes();
#endregion


#region criando classe genérica
//Generica<int> teste1 = new Generica<int>();
//teste1.MostrarMensagem(10);

//Generica<string> teste2 = new Generica<string>();
//teste2.MostrarMensagem("Olá!");
//public class Generica<T>
//{
//    public void MostrarMensagem(T t)
//    {
//        Console.WriteLine($"Exibindo {t}");
//    }
//}
#endregion


#region metodos para manipular listas

//List<ContaCorrente> listaA = new List<ContaCorrente>()
//{
//    new ContaCorrente(123),
//    new ContaCorrente(456),
//    new ContaCorrente(789)
//};

//List<ContaCorrente> listaB = new List<ContaCorrente>()
//{
//    new ContaCorrente(147),   
//    new ContaCorrente(258),
//    new ContaCorrente(369)
//};

//listaA.AddRange(listaB);    

//for(int i = 0; i < listaA.Count; i++)
//{
//    Console.WriteLine($"Índice [{i}] = Conta [{listaA[i].Conta}]");
//}

//Console.WriteLine("\n\n");

//listaA.Reverse();

//for (int i = 0; i < listaA.Count; i++)
//{
//    Console.WriteLine($"Índice [{i}] = Conta [{listaA[i].Conta}]");
//}
//Console.WriteLine("\n\n");


//var range = listaA.GetRange(0,1);

//for (int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"Índice [{i}] = Conta [{range[i].Conta}]");
//}
//Console.WriteLine("\n\n");


//listaA.Clear();

//for (int i = 0; i < listaA.Count; i++)
//{
//    Console.WriteLine($"Índice [{i}] = Conta [{listaA[i].Conta}]");
//}

#endregion


#region Desafio nome dos escolhidos

//List<string> nomeDosEscolhidos = new List<string>()
//{
//    "Bruce Wayne",
//    "Carlos Vilagran",
//    "Richard Grayson",
//    "Bob Kane",
//    "Will Farrel",
//    "Lois Lane",
//    "General Welling",
//    "Perla Letícia",
//    "Uxas",
//    "Diana Prince",
//    "Elisabeth Romanova",
//    "Anakin Wayne"
//};    


//void verificaSeContemNome(string nomeDoEscolhido)
//{
//    int index = nomeDosEscolhidos.IndexOf(nomeDoEscolhido);
//    if (index != -1)
//    {
//        Console.WriteLine($"Nome encontrado, posição: {index} da lista.");
//    } else
//    {
//        Console.WriteLine("Nome não encontrado!");
//    }
//}

//verificaSeContemNome("Perla Letícia");

#endregion


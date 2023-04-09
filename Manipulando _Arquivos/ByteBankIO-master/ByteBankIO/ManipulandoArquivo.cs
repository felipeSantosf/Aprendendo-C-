using ByteBankIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankIO
{
    static class ManipulandoArquivo
    {
        public static void LendoArquivoComReader()
        {
            var enderecoDoArquivo = "contas.txt";
            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var leitor = new StreamReader(fluxoDeArquivo);


                //var linha = leitor.ReadLine();

                //var texto = leitor.ReadToEnd();

                //var numero = leitor.Read();

                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    var contaCorrente = ConverterStringParaContaCorrente(linha);

                    var msg = $"{contaCorrente.Titular.Nome}: Conta número {contaCorrente.Numero}, ag {contaCorrente.Agencia}, saldo {contaCorrente.Saldo} ";
                    Console.WriteLine(msg);
                }

                Console.ReadLine();
            }
        }

        public static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            var campos = linha.Split(";");

            var agencia = campos[0];
            var conta = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];

            var agenciaComInt = int.Parse(agencia);
            var contaComInt = int.Parse(conta);
            var saldoComDouble = double.Parse(saldo);

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agenciaComInt, contaComInt);
            resultado.Depositar(saldoComDouble);
            resultado.Titular = titular;

            return resultado;
        }

        public static void CriarArquivoComWriter()
        {
            var caminhoDoArquivo = "contasExportadas.csv";
            using (var fluxoDeArquivo = new FileStream(caminhoDoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                escritor.Write("456,65465,456.0, Pedro");
            }
        }

        public static void TestaEscrita()
        {
            var caminhoNovoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 10; i++)
                {
                    escritor.WriteLine($"Linha {i}");
                    escritor.Flush();
                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter para continuar...");
                    Console.ReadKey();
                }
            }
        }

        public static void EscritaBinaria()
        {
            using (var fs = new FileStream("ContaCorrente.txt", FileMode.Create))
            using (var escritor = new BinaryWriter(fs))
            {
                escritor.Write(213);        // Número agência
                escritor.Write(43565);      // Número da conta
                escritor.Write(5665.45);    // Saldo
                escritor.Write("Gustavo Braga");
            }
        }

        public static void LeituraBinaria()
        {
            using (var fluxoDoArquivo = new FileStream("ContaCorrente.txt", FileMode.Open))
            using (var leitor = new BinaryReader(fluxoDoArquivo))
            {
                var agencia = leitor.ReadInt32();
                var numeroConta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"Agência: {agencia}, conta: {numeroConta}, saldo: {saldo}, titular: {titular}");
            }


        }

        public static void UsarStreamDeEntrada()
        {
            using (var fluxoEntrada = Console.OpenStandardInput())
            using (var fs = new FileStream("entradaConsole.txt", FileMode.Create))
            {
                var buffer = new byte[1024]; //1KB7

                while(true)
                {
                    var bytesLidos = fluxoEntrada.Read(buffer, 0, 1024);
                    fs.Write(buffer, 0, bytesLidos);
                    fs.Flush();
                    Console.WriteLine($"Bytes lidos na console: {bytesLidos}");
                }
            }
        }
    }
}


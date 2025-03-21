using ByteBankIO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankIO.Conteúdos_de_Aulas
{
    public class UsandoStreamReader
    {
        static void LidandoComStreamReader()
        {
            var enderecoArquivo = "contas.txt";

            using (var fluxoDeArquivo = new FileStream(enderecoArquivo, FileMode.Open))
            {
                // Instanciando o StreamReader
                var leitor = new StreamReader(fluxoDeArquivo);

                //             COMANDOS DE LEITURA

                // Ler uma linha
                var linha = leitor.ReadLine();

                // Ler o arquivo inteiro
                var texto = leitor.ReadToEnd();

                // Ler o primeiro Byte
                var numero = leitor.Read();

                // Ler uma linha de cada vez, até o final do arquivo - Reduz o uso de memória para arquivos grandes
                while (!leitor.EndOfStream)
                {
                    var linha2 = leitor.ReadLine();

                    var contaCorrente = ConverterStringParaContaCorrente(linha2);

                    Console.WriteLine(linha2);
                }
            }
        }

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            // As informações do arquivo em questão são separadas por espaço
            var campos = linha.Split(',');

            // Guardar os valores nas variaveis com os tipos corretos
            int agencia = int.Parse(campos[0]);
            int numero = int.Parse(campos[1]);
            double saldo = double.Parse(campos[2].Replace('.', ','));
            var nomeTitular = campos[3];

            // Criar o objeto Cliente
            var titular = new Cliente();
            titular.Nome = nomeTitular;

            // Criar o objeto ContaCorrente
            var resultado = new ContaCorrente(agencia, numero);
            resultado.Depositar(saldo);
            resultado.Titular = titular;

            return resultado;
        }
    }
}

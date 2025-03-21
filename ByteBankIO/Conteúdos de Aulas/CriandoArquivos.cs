using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankIO.Conteúdos_de_Aulas
{
    public class CriandoArquivos
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas1.csv"; // Nome e caminho do arquivo

            using (var fluxoDeArquivos = new FileStream(caminhoNovoArquivo, FileMode.Create)) // Criando o arquivo com FileStream
            using (var escritor = new StreamWriter(fluxoDeArquivos, Encoding.UTF8)) // Escrendo os dados no arquivo usando o StreamWriter
            {
                escritor.Write("456,78945,4785.50,Maria"); // Conteúdo do arquivo
            }
        }

        static void TestaEscrita()
        {
            var caminhoNovoArquivo = "teste.txt"; // Nome e caminho do arquivo

            using (var fluxoDeArquivos = new FileStream(caminhoNovoArquivo, FileMode.Create)) // Criando o arquivo com FileStream
            using (var escritor = new StreamWriter(fluxoDeArquivos, Encoding.UTF8)) // Escrendo os dados no arquivo usando o StreamWriter
            {
                for (int i = 0; i < 100000; i++)
                {
                    escritor.WriteLine($"Linha {i}");
                    escritor.Flush(); // Força a escrita do buffer
                    escritor.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter");
                    Console.ReadLine();
                }
            }
        }
    }
}

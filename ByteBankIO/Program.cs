using ByteBankIO;
using ByteBankIO.Models;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {

        var linhas = File.ReadAllLines("contas.txt"); // Lendo o arquivo inteiro e guardando em um array de strings
        Console.WriteLine(linhas.Length); // Imprimindo quantas linhas tem o arquivo

        foreach (var linha in linhas) // Lendo cada linha do arquivo
        {
            Console.WriteLine(linha); // Imprimindo cada linha
        }

        var linhasBytes = File.ReadAllBytes("contas.txt"); // Lendo o arquivo inteiro em forma de BYTES

        File.WriteAllText("ArquivoBibliotecaFile", "Blablablablabla"); // Escrevendo um arquivo com o conteúdo passado

        Console.ReadLine();
    }

    
    }
}
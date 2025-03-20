using ByteBankIO;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        //LidandoComFileStreamDiretamente.LidandoComFileStream();

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
                Console.WriteLine(linha2);
            }
        }

        Console.ReadLine();
    }
}
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string caminhoArquivo = "contas.txt";

        // Assim que o buffer passa pelo arquivo inteiro, ele fica retornando 0 sem parar, então temos que limitar isso
        var numeroDeBytesLidos = -1;

        // Criando uma FileStream do arquivo
        FileStream fluxoDoArquivo = new FileStream(caminhoArquivo, FileMode.Open);

        // Criando o array de Buffer (temporário, ficar trocando informação pra economizar processamento)
        byte[] buffer = new byte[1024];

        // Lendo o arquivo
        while (numeroDeBytesLidos != 0)
        {
            numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
            EscreverBuffer(buffer);
        }

        Console.ReadLine();
    }

    static void EscreverBuffer(byte[] buffer)
    {
        // Decodificando o buffer em string
        var utf8 = new UTF8Encoding();

        var texto = utf8.GetString(buffer);
        Console.Write(texto);

        /*
        foreach (byte b in buffer)
        {
            Console.Write(b);
            Console.Write(" ");
        }*/
    }
}
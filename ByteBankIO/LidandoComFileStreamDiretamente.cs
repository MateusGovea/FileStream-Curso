using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankIO
{
    public class LidandoComFileStreamDiretamente
    {

        static void LidandoComFileStream()
        {
            string caminhoArquivo = "contas.txt";

            // Assim que o buffer passa pelo arquivo inteiro, ele fica retornando 0 sem parar, então temos que limitar isso
            var numeroDeBytesLidos = -1;

            // Criando uma FileStream do arquivo
            using (FileStream fluxoDoArquivo = new FileStream(caminhoArquivo, FileMode.Open))
            {
                // Criando o array de Buffer (temporário, ficar trocando informação pra economizar processamento)
                byte[] buffer = new byte[1024];

                // Lendo o arquivo
                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }

                Console.ReadLine();

                // Fechando o arquivo
                fluxoDoArquivo.Close();
            }
        }

        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            // Decodificando o buffer em string
            var utf8 = new UTF8Encoding();

            // Mandando ele ler o que tem no buffer(1), começando na posição 0(2), e lendo até onde tem bytesLidos(3)
            // Isso serve pra evitar que ele guarde os bytes da ultima leitura, quando o buffer é maior que o tamanho restando do arquivo
            var texto = utf8.GetString(buffer, 0, bytesLidos);

            Console.Write(texto);
        }
    }
}

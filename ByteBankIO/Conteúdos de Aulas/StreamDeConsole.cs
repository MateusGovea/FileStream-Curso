using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankIO.Conteúdos_de_Aulas
{
    public class StreamDeConsole
    {
        static void StreamDeEntrada()
        {
            using (var fluxoDeEntrada = Console.OpenStandardInput())
            using (var fs = new FileStream("entradaConsole.txt", FileMode.Create))
            {
                var buffer = new byte[1024];
                while (true)
                {
                    var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024); // Escrevendo o conteúdo do console usando um buffer
                    fs.Flush(); // Flush para forçar a escrita do buffer
                    Console.WriteLine($"Bytes lidos da console: {bytesLidos}");
                }
            }
        }
    }
}

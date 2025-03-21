using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankIO.Conteúdos_de_Aulas
{
    public class BinaryStream
    {
        static void EscritaBinaria()
        {
            using (var fs = new FileStream("contaCorrenteBinario.txt", FileMode.Create))
            using (var escritor = new BinaryWriter(fs))
            {
                escritor.Write(456);              // Agência
                escritor.Write(78945);            // Número
                escritor.Write(4000.50);          // Saldo
                escritor.Write("Gustavo Braga");  // Nome do titular
            }
        }

        static void LeituraBinaria()
        {
            using (var fs = new FileStream("contaCorrenteBinario.txt", FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var numero = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();
                Console.WriteLine($"Agência: {agencia}, Número: {numero}, Saldo: {saldo}, Titular: {titular}");
            }
        }
    }
}

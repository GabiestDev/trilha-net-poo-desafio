using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testes com Nokia:");
            Nokia nokia = new Nokia(numero: "11987654321", modelo: "Nokia G21", imei: "123456789012345", memoria: 128);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");
            Console.WriteLine($"Número do Nokia: {nokia.Numero}");
            Console.WriteLine($"Modelo do Nokia: {nokia.Modelo}");
            Console.WriteLine($"IMEI do Nokia: {nokia.IMEI}");
            Console.WriteLine($"Memória do Nokia: {nokia.Memoria}GB");

            Console.WriteLine("\n------------------------------\n");

            Console.WriteLine("Testes com iPhone:");
            Iphone iphone = new Iphone(numero: "21912345678", modelo: "iPhone 15 Pro", imei: "987654321098765", memoria: 512);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
            Console.WriteLine($"Número do iPhone: {iphone.Numero}");
            Console.WriteLine($"Modelo do iPhone: {iphone.Modelo}");
            Console.WriteLine($"IMEI do iPhone: {iphone.IMEI}");
            Console.WriteLine($"Memória do iPhone: {iphone.Memoria}GB");
        }
    }
}
using AulaArquiteturaSoftwarePolimorfismo.Model;
using System;

namespace AulaArquiteturaSoftwarePolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto objMoto = new Moto("CG", 2020, "vermelho");
            Console.WriteLine(objMoto.Ligar());
            Console.WriteLine(objMoto.Andar());
            Console.WriteLine(objMoto.Parar());
        }
    }
}

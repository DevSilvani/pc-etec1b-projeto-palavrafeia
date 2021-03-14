using System;

namespace pc_etec1b_projeto_palavrafeia
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "";
            int i = 0;
            string[] palavrasfeias = {"chato","chata", "bobo","boba", "feio","feia", "boboca", "bocó", "tonto","tonta", "palerma", "paspalho","paspalha", "tantã", "panaca", "pentelho","pentelha", "burro","burra", "besta"};
            Console.Write("Digite uma frase: ");
            frase = Console.ReadLine();
            for(i=0;i<20;i++){
                frase = frase.Replace(palavrasfeias[i], "****");
            }
            Console.Clear();
            Console.WriteLine("frase corrigida: "+frase);
            Console.ReadKey();
        }
    }
}

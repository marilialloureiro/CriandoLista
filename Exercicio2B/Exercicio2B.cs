using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2B
{

    //Desenvolvam uma outra versao do programa de lista de convidados agora usando List.
    public class Exercicio2B
    {
        public static void Main() 
        {
            List<string> convidados = new List<string>();
            convidados.Add("João");
            convidados.Add("Maria");
            convidados.Add("Mariana");
            convidados.Add("Marilia");
            convidados.Add("José");
            convidados.Add("Eduardo");

            Console.WriteLine("O número de convidados na lista é de: " + convidados.Count);
            Console.WriteLine("Convidado: " + convidados[0]);
            Console.WriteLine("Convidado: " + convidados[1]);
            Console.WriteLine("Convidado: " + convidados[2]);
            Console.WriteLine("Convidado: " + convidados[3]);
            Console.WriteLine("Convidado: " + convidados[4]);
            Console.WriteLine("Convidado: " + convidados[5]);
        }
    }
}

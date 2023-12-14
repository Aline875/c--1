using System;
namespace teste.models
{
    public class Pessoa
    {
        public string Nome {get; set;}
        public int Idade {get; set;}

        public void Apresentar()
        {
            Console.WriteLine($"olá, meu nome é {Nome}, e tenho {Idade} anos.");
            Console.WriteLine($"olá, meu nome é {Nome},\n e tenho {Idade} anos.");
            //Para qubrar uma linha é necessario colocar um "\n" onde a quebra é desejada.
        }
        
    }
}
using System;

namespace Flyweight
{
    public class Azul : Tartaruga
    {
        public Azul()
        {
            condicao = "tartaruga dentro do casco, ";
            acao = "rodando no chão - ";
        }
        public override void Mostra(string qualCor)
        {
            cor = qualCor;
            Console.WriteLine(condicao + acao + cor.ToUpper());
        }
    }
}
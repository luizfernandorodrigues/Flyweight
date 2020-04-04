using System;

namespace Flyweight
{
    public class Laranja : Tartaruga
    {
        public Laranja()
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
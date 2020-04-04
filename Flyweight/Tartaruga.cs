namespace Flyweight
{
    public abstract class Tartaruga
    {
        #region Atributos
        protected string condicao;
        protected string acao;
        #endregion Atributos
        public string cor { get; set; }

        public abstract void Mostra(string cor);
    }
}
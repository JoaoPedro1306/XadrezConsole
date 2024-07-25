namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdeMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            QtdeMovimentos = 0;
            Tabuleiro = tabuleiro;
        }

        public void IncrementarQtdeMovimentos()
        {
            QtdeMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
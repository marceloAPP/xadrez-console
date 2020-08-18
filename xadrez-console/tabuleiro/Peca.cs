namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMoviemntos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, int qteMoviemntos, Tabuleiro tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.qteMoviemntos = qteMoviemntos;
            this.tab = tab;
            this.qteMoviemntos = 0;
        }
    }
}

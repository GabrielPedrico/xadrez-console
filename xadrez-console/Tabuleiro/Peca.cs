namespace Tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int qteMovimentos { get; protected set; } // Pode ser acessada porem so pode ser modificada por subclasses
        public tabuleiro tab { get; protected set; } // Pode ser acessada porem so pode ser modificada por subclasses

        public Peca(Posicao posicao,tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }
    }
}

namespace Tabuleiro
{
    class tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }

        private Peca[,] pecas;
        public tabuleiro (int linhas,int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna) // Funcao que retorna a localizacao da peca no tabuleiro
        {
            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca p, Posicao pos) // Funcao que coloca as pecas no tabuleiro
        {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
    }
}

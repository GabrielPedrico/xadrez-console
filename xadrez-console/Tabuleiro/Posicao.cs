namespace Tabuleiro
{
    class Posicao
    {
        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int linha, int coluna) // Construtor para receber Linha e Coluna
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString() // Funcao para definir como sera o formato de sua impressao para o usuario com Console.WriteLine();
        {
            return linha // Retorna o valor da linha concatenado com uma "," e o valor da coluna
            + ","
            + coluna;
        }


    }
}

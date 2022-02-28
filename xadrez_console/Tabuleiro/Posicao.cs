using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuleiro
{
    public class Posicao
    {
        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int Linha, int Coluna)
        {
            linha = Linha;
            coluna = Coluna;
        }

        public override string ToString()
        {
            return linha + "," + coluna;
        }
    }
}

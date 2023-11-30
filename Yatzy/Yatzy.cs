using System.Collections.Generic;
using System.Linq;

namespace Yatzy
{
    public class Yatzy
    {
        private readonly Categoria[] categorias;
        public Yatzy()
        {
            categorias = new Categoria[]
            {
                new Categoria.Ones(),
                new Categoria.Twos(),
                new Categoria.Threes(),
                new Categoria.Fours(), 
                new Categoria.Fives(),
                new Categoria.Sixes(),
                new Categoria.Chance(),
                new Categoria.YatzyCategory(),
                new Categoria.FullHouse(),
                new Categoria.ScorePair(),
                new Categoria.TwoPair(),
                new Categoria.FourOfAKind(),
                new Categoria.ThreeOfAKind(),
                new Categoria.SmallStraight(),
                new Categoria.LargeStraight(),
            };
        }
        
        public int CalcularPontuacao(int[] dados, Categoria categoria)
        {
            return categoria.Score(dados);
        }
    }
}
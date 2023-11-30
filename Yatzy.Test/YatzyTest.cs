using Xunit;

namespace Yatzy.Test
{
    public class YatzyTest
    {
        [Fact]
        public void Chance_scores_sum_of_all_dice()
        {
            var yatzy = new Yatzy();
            var expected = 15;
            var actual = yatzy.CalcularPontuacao(new[] { 2, 3, 4, 5, 1 }, new Categoria.Chance());
            Assert.Equal(expected, actual);
            Assert.Equal(16, yatzy.CalcularPontuacao(new[] { 3, 3, 4, 5, 1 }, new Categoria.Chance()));
        }

        [Fact]
        public void Fact_1s()
        {
            var yatzy = new Yatzy();
            Assert.True(yatzy.CalcularPontuacao(new[] { 1, 2, 3, 4, 5 }, new Categoria.Ones()) == 1);
            Assert.Equal(2, yatzy.CalcularPontuacao(new[] { 1, 2, 1, 4, 5 }, new Categoria.Ones()));
            Assert.Equal(0, yatzy.CalcularPontuacao(new[] { 6, 2, 2, 4, 5 }, new Categoria.Ones()));
            Assert.Equal(4, yatzy.CalcularPontuacao(new[] { 1, 2, 1, 1, 1 }, new Categoria.Ones()));
        }

        [Fact]
        public void Fact_2s()
        {
            var yatzy = new Yatzy();
            Assert.Equal(4, yatzy.CalcularPontuacao(new[] { 1, 2, 3, 2, 6 }, new Categoria.Twos()));
            Assert.Equal(10, yatzy.CalcularPontuacao(new[] { 2, 2, 2, 2, 2 }, new Categoria.Twos()));
        }

        [Fact]
        public void Fact_threes()
        {
            var yatzy = new Yatzy();
            Assert.Equal(6, yatzy.CalcularPontuacao(new[] { 1, 2, 3, 2, 3 }, new Categoria.Threes()));
            Assert.Equal(12, yatzy.CalcularPontuacao(new[] { 2, 3, 3, 3, 3 }, new Categoria.Threes()));
        }

        [Fact]
        public void fives()
        {
            var yatzy = new Yatzy();
            Assert.Equal(10, yatzy.CalcularPontuacao(new[] { 4, 4, 4, 5, 5 }, new Categoria.Fives()));
            Assert.Equal(15, yatzy.CalcularPontuacao(new[] { 4, 4, 5, 5, 5 }, new Categoria.Fives()));
            Assert.Equal(20, yatzy.CalcularPontuacao(new[] { 4, 5, 5, 5, 5 }, new Categoria.Fives()));
        }

        [Fact]
        public void four_of_a_knd()
        {
            var yatzy = new Yatzy();
            Assert.Equal(12, yatzy.CalcularPontuacao(new[] { 3, 3, 3, 3, 5 }, new Categoria.FourOfAKind()));
            Assert.Equal(20, yatzy.CalcularPontuacao(new[] { 5, 5, 5, 4, 5 }, new Categoria.FourOfAKind()));
            Assert.Equal(12, yatzy.CalcularPontuacao(new[] { 3, 3, 3, 3, 3 }, new Categoria.FourOfAKind()));
        }

        [Fact]
        public void fours_Fact()
        {
            var yatzy = new Yatzy();
            Assert.Equal(12, yatzy.CalcularPontuacao(new[] { 4, 4, 4, 5, 5 }, new Categoria.Fours()));
            Assert.Equal(8, yatzy.CalcularPontuacao(new[] { 4, 4, 5, 5, 5 }, new Categoria.Fours()));
            Assert.Equal(4, yatzy.CalcularPontuacao(new[] { 4, 5, 5, 5, 5 }, new Categoria.Fours()));
        }

        [Fact]
        public void fullHouse()
        {
            var yatzy = new Yatzy();
            Assert.Equal(18, yatzy.CalcularPontuacao(new[] { 6, 2, 2, 2, 6 }, new Categoria.FullHouse()));
            Assert.Equal(0, yatzy.CalcularPontuacao(new[] { 2, 3, 4, 5, 6 }, new Categoria.FullHouse()));
        }

        [Fact]
        public void largeStraight()
        {
            var yatzy = new Yatzy();
            Assert.Equal(20, yatzy.CalcularPontuacao(new[] { 6, 2, 3, 4, 5 }, new Categoria.LargeStraight()));
            Assert.Equal(20, yatzy.CalcularPontuacao(new[] { 2, 3, 4, 5, 6 }, new Categoria.LargeStraight()));
            Assert.Equal(0, yatzy.CalcularPontuacao(new[] { 1, 2, 2, 4, 5 }, new Categoria.LargeStraight()));
        }

        [Fact]
        public void one_pair()
        {
            var yatzy = new Yatzy();
            Assert.Equal(6, yatzy.CalcularPontuacao(new[] { 3, 4, 3, 5, 6 }, new Categoria.ScorePair()));
            Assert.Equal(10, yatzy.CalcularPontuacao(new[] { 5, 3, 3, 3, 5 }, new Categoria.ScorePair()));
            Assert.Equal(12, yatzy.CalcularPontuacao(new[] { 5, 3, 6, 6, 5 }, new Categoria.ScorePair()));
        }

        [Fact]
        public void sixes_Fact()
        {
            var yatzy = new Yatzy();
            Assert.Equal(0, yatzy.CalcularPontuacao(new[] { 4, 4, 4, 5, 5 }, new Categoria.Sixes()));
            Assert.Equal(6, yatzy.CalcularPontuacao(new[] { 4, 4, 6, 5, 5 }, new Categoria.Sixes()));
            Assert.Equal(18, yatzy.CalcularPontuacao(new[] { 6, 5, 6, 6, 5 }, new Categoria.Sixes()));
        }

        [Fact]
        public void smallStraight()
        {
            var yatzy = new Yatzy();
            Assert.Equal(15, yatzy.CalcularPontuacao(new[] { 1, 2, 3, 4, 5 }, new Categoria.SmallStraight()));
            Assert.Equal(15, yatzy.CalcularPontuacao(new[] { 2, 3, 4, 5, 1 }, new Categoria.SmallStraight()));
            Assert.Equal(0, yatzy.CalcularPontuacao(new[] { 1, 2, 2, 4, 5 }, new Categoria.SmallStraight()));
        }

        [Fact]
        public void three_of_a_kind()
        {
            var yatzy = new Yatzy();
            Assert.Equal(9, yatzy.CalcularPontuacao(new[] { 3, 3, 3, 4, 5 }, new Categoria.ThreeOfAKind()));
            Assert.Equal(15, yatzy.CalcularPontuacao(new[] { 5, 3, 5, 4, 5 }, new Categoria.ThreeOfAKind()));
            Assert.Equal(9, yatzy.CalcularPontuacao(new[] { 3, 3, 3, 3, 5 }, new Categoria.ThreeOfAKind()));
        }

        [Fact]
        public void two_Pair()
        {
            var yatzy = new Yatzy();
            Assert.Equal(16, yatzy.CalcularPontuacao(new[] { 3, 3, 5, 4, 5 }, new Categoria.TwoPair()));
            Assert.Equal(16, yatzy.CalcularPontuacao(new[] { 3, 3, 5, 5, 5 }, new Categoria.TwoPair()));
        }

        [Fact]
        public void Yatzy_scores_50()
        {
            var yatzy = new Yatzy();
            var expected = 50;
            var actual = yatzy.CalcularPontuacao(new[] { 4, 4, 4, 4, 4 }, new Categoria.YatzyCategory());
            Assert.Equal(expected, actual);
            Assert.Equal(50, yatzy.CalcularPontuacao(new[] { 6, 6, 6, 6, 6 }, new Categoria.YatzyCategory()));
            Assert.Equal(0, yatzy.CalcularPontuacao(new[] { 6, 6, 6, 6, 3 }, new Categoria.YatzyCategory()));
        }
    }
}

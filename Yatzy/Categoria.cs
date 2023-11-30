using System.Linq;

public abstract class Categoria
{
    public abstract int Score(int[] dados);

    public class Ones : Categoria
    {
        public override int Score(int[] dados) => dados.Count(dado => dado == 1);
    }

    public class Twos : Categoria
    {
        public override int Score(int[] dados) => dados.Count(dado => dado == 2) * 2;
    }

    public class Threes : Categoria
    {
        public override int Score(int[] dados) => dados.Count(dado => dado == 3) * 3;
    }

    public class Fours : Categoria
    {
        public override int Score(int[] dados) => dados.Count(dado => dado == 4) * 4;
    }

    public class Fives : Categoria
    {
        public override int Score(int[] dados) => dados.Count(dado => dado == 5) * 5;
    }

    public class Sixes : Categoria
    {
        public override int Score(int[] dados) => dados.Count(dado => dado == 6) * 6;
    }

    public class Chance : Categoria
    {
        public override int Score(int[] dados) => dados.Sum();
    }

    public class YatzyCategory  : Categoria
    {
        public override int Score(int[] dados) => dados.All(dado => dado == dados[0]) ? 50 : 0;
    }

    public class FullHouse : Categoria
    {
        public override int Score(int[] dados)
        {
            var agrupados = dados.GroupBy(x => x);
            return agrupados.Count(g => g.Count() == 2) == 1 && agrupados.Count(g => g.Count() == 3) == 1
                ? dados.Sum()
                : 0;
        }
    }

    public class ScorePair : Categoria
    {
        public override int Score(int[] dados)
        {
            var agrupados = dados.GroupBy(x => x);
            var par = agrupados.Where(g => g.Count() >= 2).OrderByDescending(g => g.Key).FirstOrDefault();
            return par != null ? par.Key * 2 : 0;
        }
    }

    public class TwoPair : Categoria
    {
        public override int Score(int[] dados)
        {
            var agrupados = dados.GroupBy(x => x);
            var pares = agrupados.Where(g => g.Count() >= 2).OrderByDescending(g => g.Key).Take(2);
            return pares.Count() == 2 ? pares.Sum(par => par.Key * 2) : 0;
        }
    }

    public class FourOfAKind : Categoria
    {
        public override int Score(int[] dados)
        {
            var agrupados = dados.GroupBy(x => x);
            var quadra = agrupados.FirstOrDefault(g => g.Count() >= 4);
            return quadra != null ? quadra.Key * 4 : 0;
        }
    }

    public class ThreeOfAKind : Categoria
    {
        public override int Score(int[] dados)
        {
            var agrupados = dados.GroupBy(x => x);
            var trinca = agrupados.FirstOrDefault(g => g.Count() >= 3);
            return trinca != null ? trinca.Key * 3 : 0;
        }
    }

    public class SmallStraight : Categoria
    {
        public override int Score(int[] dados) => IsStraight(dados, 1, 5) ? 15 : 0;
    }

    public class LargeStraight : Categoria
    {
        public override int Score(int[] dados) => IsStraight(dados, 2, 6) ? 20 : 0;
    }

    private static bool IsStraight(int[] dados, int inicio, int fim)
    {
        return dados.Distinct().OrderBy(d => d).SequenceEqual(Enumerable.Range(inicio, fim - inicio + 1));
    }
}
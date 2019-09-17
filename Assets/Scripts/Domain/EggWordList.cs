using System.Linq;

namespace Domain
{
    //卵料理のデータ一覧を管理するクラス
    public class EggWordList
    {
        readonly EggWord[] list =
        {
            new EggWord("Tamagoyaki", EggRank.B),
            new EggWord("Fried egg", EggRank.C),
            new EggWord("Scrambled eggs", EggRank.C),
            new EggWord("Chawanmushi", EggRank.A),
            new EggWord("Egg tofu", EggRank.B)
        };

        //卵料理のワードからEggRankを取得する
        public EggRank GetEggRank(string word)
        {
            var rank = list.FirstOrDefault(x => x.word == word)?.eggRank;
            if (rank.HasValue) return rank.Value;
            return EggRank.Nothing;
        }
    }
}
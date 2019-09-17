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
            new EggWord("Egg tofu", EggRank.B),
            new EggWord("Oyakodon", EggRank.A), 
            new EggWord("Katsudon", EggRank.B), 
            new EggWord("玉子丼", EggRank.B), 
            new EggWord("Egg", EggRank.C), 
            new EggWord("Yolk", EggRank.C), 
            new EggWord("Tamago kake gohan", EggRank.C), 
            new EggWord("Boiled egg", EggRank.B), 
            new EggWord("Onsen tamago", EggRank.B), 
            new EggWord("Chicken egg", EggRank.C), 
            new EggWord("たまごふわふわ", EggRank.A), 
            new EggWord("Omelette", EggRank.B), 
            new EggWord("Spanish omelette", EggRank.A) 
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
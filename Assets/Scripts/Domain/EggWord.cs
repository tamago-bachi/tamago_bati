namespace Domain
{
    //卵料理のワード情報
    class EggWord
    {
        public readonly string word;
        public readonly EggRank eggRank;

        public EggWord(string word, EggRank eggRank)
        {
            this.word = word;
            this.eggRank = eggRank;
        }
    }
}
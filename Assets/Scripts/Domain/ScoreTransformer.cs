namespace Domain
{
    //スコアに変換するクラス
    class ScoreTransformer
    {
        //ランクからスコアを取得する関数
        public uint GetScoreFromRank(EggRank rank)
        {
            switch (rank)
            {
                case EggRank.A:
                    return 20;                
                case EggRank.B:
                    return 10;                
                case EggRank.C:
                    return 5;
            }
            return 0;
        }
    }
}
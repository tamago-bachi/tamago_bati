using System;
using UnityEngine.SocialPlatforms.Impl;

namespace Domain
{
    //発展度の管理をするクラス
    class DevelopmentLevelManager
    {
        DevelopmentLevel developmentLevel = DevelopmentLevel.Level1;
        uint totalScore = 0;
        public event Action<DevelopmentLevel> DevelopmentLevelChenged;

        //スコアを加算する関数
        public void AddScore(uint score)
        {
            totalScore += score;
            DevelopmentLevel level = ChangeDevelopmentLevel(totalScore);
            if (level != developmentLevel)
            {
                developmentLevel = level;
                DevelopmentLevelChenged?.Invoke(developmentLevel);
            }
        }
        
        //内部の発展度状態を変える関数
        static DevelopmentLevel ChangeDevelopmentLevel(uint totalScore)
        {
            if (totalScore >= 150)
            {
                return DevelopmentLevel.Level5;
            }
            else if (totalScore >= 80)
            {
                return DevelopmentLevel.Level4;
            }
            else if (totalScore >= 40)
            {
                return DevelopmentLevel.Level3;
            }
            else if (totalScore >= 15)
            {
                return DevelopmentLevel.Level2;
            }
            else
            {
                return DevelopmentLevel.Level1;
            }
        }
        
    }
}
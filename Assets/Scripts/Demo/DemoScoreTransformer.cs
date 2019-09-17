using Domain;
using UnityEngine;

namespace Demo
{
    public class DemoScoreTransformer : MonoBehaviour
    {
        void Start()
        {
            var score = new ScoreTransformer().GetScoreFromRank(EggRank.A);
            Debug.Log(score);
        }
    }
}
using Infrastructure;
using UnityEngine;

namespace Demo
{
    public class DemoDetermineRank : MonoBehaviour
    {
        void Start()
        {
            var rank = new EggDishesRankChecker().EggDishImageToRank("Assets/Imgs/egg.jpg");
            Debug.Log(rank);
        }
    }
}
using Domain;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using System.Collections;

namespace Infrastructure
{
    //ランクによって魚を生成するクラス
    public class FishGenerator : MonoBehaviour
    {
        [SerializeField] GameObject tunaA;
        [SerializeField] GameObject tunaB;
        [SerializeField] GameObject tunaC;
        [SerializeField] GameObject fishA;
        [SerializeField] GameObject fishB;
        [SerializeField] GameObject fishC;
        
        //ランクによって生成する魚を決める関数
        public void GenerateFish(EggRank rank)
        {
            GameObject generate = null;
            switch (rank)
            {
                case EggRank.A:
                    if (Random.Range(0, 2) == 0)
                    {
                        generate = tunaA;
                    }
                    else
                    {
                        generate = fishA;
                    }
                    break;
                case EggRank.B:
                    if (Random.Range(0, 2) == 0)
                    {
                        generate = tunaB;
                    }
                    else
                    {
                        generate = fishB;
                    }
                    break;
                case EggRank.C:
                    if (Random.Range(0, 2) == 0)
                    {
                        generate = tunaC;
                    }
                    else
                    {
                        generate = fishC;
                    }

                    break;
                default:
                    break;
            }
            if (generate != null)
            {
                Instantiate(generate);
            }
        }
    }
}
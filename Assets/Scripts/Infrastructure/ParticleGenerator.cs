using Domain;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using System.Collections;

namespace Infrastructure
{
    //パーティクルを生成するクラス
    public class ParticleGenerator : MonoBehaviour
    {
        [SerializeField] GameObject particleA;
        [SerializeField] GameObject particleB;
        [SerializeField] GameObject particleC;
        [SerializeField] GameObject particleNothing;
        
        //ランクによってパーティクルの演出を決める関数
        public void GenerateParticle(EggRank rank)
        {
            GameObject generate = null;
            switch (rank)
            {
                case EggRank.A:
                    generate = particleA;
                    break;
                case EggRank.B:
                    generate = particleB;
                    break;
                case EggRank.C:
                    generate = particleC;
                    break;
                default:
                    generate = particleNothing;
                    break;
            }
            if (generate != null)
            {
                var instance = Instantiate(generate);
                instance.transform.position=new Vector3(0,0,-2);
            }
        }
    }
}
using Domain;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using System.Collections;
using System.Collections.Generic;

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
        [SerializeField] GameObject piranhaA;
        [SerializeField] GameObject piranhaB;
        [SerializeField] GameObject piranhaC;
        Dictionary<EggRank, GameObject[]> fishDictionary;

        void Awake()
        {
            fishDictionary = new Dictionary<EggRank, GameObject[]>()
            {
                {EggRank.A, new GameObject[] {tunaA, fishA, piranhaA}},
                {EggRank.B, new GameObject[] {tunaB, fishB, piranhaB}},
                {EggRank.C, new GameObject[] {tunaC, fishC, piranhaC}}
            };
        }

        //ランクによって生成する魚を決める関数
        public void GenerateFish(EggRank rank)
        {
            if (rank == EggRank.Nothing)
            {
                return;
            }
            var instance = Instantiate(fishDictionary[rank][Random.Range(0, 3)]);
            instance.transform.position = new Vector3(0, 0, -5);
            instance.AddComponent<FishMover>();
        }
    }
}
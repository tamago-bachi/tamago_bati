using System.Diagnostics;
using Domain;
using Infrastructure;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace Demo
    {
        public class DemoFishGenerator : MonoBehaviour
        {
            [SerializeField] private FishGenerator fishGenerator;
            void Start()
            {
                fishGenerator.GenerateFish(EggRank.B);
                Debug.Log(fishGenerator);
            }
        }
    }
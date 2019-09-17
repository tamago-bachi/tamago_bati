using System.Diagnostics;
using Domain;
using Infrastructure;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace Demo
{
    public class DemoParticleGenerator : MonoBehaviour
    {
        [SerializeField] ParticleGenerator particleGenerator;
        void Start()
        {
            particleGenerator.GenerateParticle(EggRank.Nothing);
        }
    }
}
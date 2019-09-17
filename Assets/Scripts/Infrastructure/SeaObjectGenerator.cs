using Domain;
using UnityEngine;

namespace Infrastructure
{
    public class SeaObjectGenerator : MonoBehaviour
    {
        [SerializeField] GameObject islandPrefab;
        [SerializeField] GameObject coralReefPrefab;
        [SerializeField] GameObject palmTreePrefab;
        [SerializeField] GameObject submarineVolcanoPrefab;

        public void GenerateSeaObject(DevelopmentLevel developmentLevel)
        {
            switch (developmentLevel)
            {
                case DevelopmentLevel.Level2:
                    Object.Instantiate(submarineVolcanoPrefab);
                    break;
                case DevelopmentLevel.Level3:
                    Object.Instantiate(coralReefPrefab);
                    break;
                case DevelopmentLevel.Level4:
                    Object.Instantiate(islandPrefab);
                    break;
                case DevelopmentLevel.Level5:
                    Object.Instantiate(palmTreePrefab);
                    break;
            }
        }
    }
}
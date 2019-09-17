using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleCreate : MonoBehaviour
{
    [SerializeField] GameObject BubblePrefab;
    int count;
    int maxCount;
    
    // Start is called before the first frame update
    void Start()
    {
       maxCount = Random.Range(20, 45);
        count = maxCount;
    }

    // Update is called once per frame
    void Update()
    {
        
        count -- ;
        if(count == 0)
        {
          Instantiate(BubblePrefab).transform.position =
                transform.position + new Vector3(-0.625f + Random.Range(1f,-1f), 0, -1.189f);
            count = Random.Range(20, 45); ;
        }
        
     }
}

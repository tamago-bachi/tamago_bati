using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMover : MonoBehaviour
{
    [SerializeField] float y ;
    [SerializeField]int count;
    int angle = 0;
    float amplitude = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angle += 3;
        amplitude /= 0.995f;
        transform.position += 
            new Vector3(Mathf.Cos(Mathf.Deg2Rad * angle) * amplitude,y,0);
        count-- ;
        if (count == 0){
            Destroy (gameObject);
        }
    }
}

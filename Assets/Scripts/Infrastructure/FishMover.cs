using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMover : MonoBehaviour
{
    int count = MAX_COUNT;
    const int MAX_COUNT = 180;
    Vector3 direction = new Vector3(0, 0, 0);


    // Start is called befoe the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        count -= 1;
        //if (count == 0) {

                //SetRandomDirection();               
               //count = MAX_COUNT;
            
        //}
        //transform.rotation(rotation);
        transform.position += transform.forward / 100;
        //Debug.Log("");
    }
    void SetRandomDirection()
    {
        float x = Random.Range(0, 360),
                    y = Random.Range(0, 360),
                    z = Random.Range(0, 360);
        transform.rotation =
        Quaternion.Euler(new Vector3(x, y, z));
    }
    void FixedUpdate()
    {
        if (CheckWall())
        {
            SetRandomDirection();
        }

    }
    bool CheckWall() {
        //int wallMask = LayerMask.NameToLayer("Wall");
        var rayResult = Physics.Raycast(transform.position, transform.forward,1.0f);
        Debug.Log(rayResult);
        Debug.DrawRay(transform.position, transform.forward * 1.0f, Color.red, 5);
        return rayResult;
    }


}

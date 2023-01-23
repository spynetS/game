using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float time = 0;
    // Update is called once per frame
    void FixedUpdate()
    {

        if(time>300){
            Destroy(gameObject);
        }

        time++;
    }
}

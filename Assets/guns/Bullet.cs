using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float time = 0;
    public int damage = 10;
    private float ctime = 0;
    public Gun from;

    void FixedUpdate()
    {

        if(ctime>time){
            Destroy(gameObject);
        }
        ctime++;
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public GameObject barrel;
    public float force = 600;

    public void hit(){
        GetComponentInParent<Player>().points++;
    }

    public void Shoot(){

        GameObject clone = Instantiate(bullet, (barrel.transform.position+(transform.forward*1)), Quaternion.identity);
        clone.GetComponent<Bullet>().from = this;
        clone.transform.LookAt(barrel.transform.position);
        try{
            clone.GetComponent<Rigidbody>().AddForce(clone.transform.forward*-force);
        }catch{}
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public GameObject barrel;
    public float force = 600;

    public void Shoot(){

        GameObject clone = Instantiate(bullet, (barrel.transform.position+(transform.up*1)), Quaternion.identity);

        clone.transform.LookAt(barrel.transform.position);
        clone.GetComponent<Rigidbody>().AddForce(clone.transform.forward*-force);
    }

}

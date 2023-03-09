using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyGun : Gun
{
    public override void Shoot(){
        GameObject clone = Instantiate(bullet, (barrel.transform.position+(transform.forward*1)), Quaternion.identity);
        clone.GetComponent<Bullet>().from = this;
        clone.transform.LookAt(barrel.transform.position);
    }
}

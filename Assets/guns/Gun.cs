using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public GameObject barrel;
    public float force = 600;
	
	public string nameid = "Deagle";
	public int damage = 10;
	public int speed = 100;
	public int timer = 0;
	public int points = 30;
	
    public void hit(){
        GetComponentInParent<Player>().points+=10;
        GetComponentInParent<Player>().hitMark(10);

    }
	
    public void die(){
        GetComponentInParent<Player>().points+=points;
    }

    public virtual void Shoot(){
			GameObject clone = Instantiate(bullet, (barrel.transform.position+(transform.forward*1)), Quaternion.identity);
			clone.GetComponent<Bullet>().from = this;
			clone.transform.LookAt(barrel.transform.position);
			try{
				clone.GetComponent<Rigidbody>().AddForce(clone.transform.forward*-force);
			}catch{}	
			timer = 0;
		
    }
	void Update(){
		if (timer >= speed && Input.GetMouseButton(0)){
			Shoot();
			timer = 0;
		}
		timer++;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public GameObject material;
    public Color firstColor;
    public Text healthText;
    int time = 0;

	public void replace(Collider other){
		int x = Random.Range(-20, 20);
        int y = Random.Range(-15, 25);
		transform.position = new Vector3(x,1,y);
        health = 100;
	    other.GetComponentInParent<Bullet>().from.die();
    }



    public void takeDamage(Collider other){
        health -= other.GetComponentInParent<Bullet>().from.damage;
       
		if(health <= 0){
			replace(other);
		}
        
		
        foreach(MeshRenderer g in GetComponentsInChildren<MeshRenderer>())
        {
            g.material.color = Color.red;
        }
        // material.GetComponent<MeshRenderer> ().material.color = Color.red;
        time = 0;
    }

    public void Start(){
        firstColor = material.GetComponent<MeshRenderer> ().material.color;

    }
    public void Update(){
        if(time > 10){
            foreach(MeshRenderer g in GetComponentsInChildren<MeshRenderer>())
            {
                g.material.color = firstColor;
            }
        }
        time++;
        healthText.text = health.ToString();
        GameObject player =GameObject.FindGameObjectsWithTag("Player")[0]; 
        healthText.transform.LookAt(player.transform.position); 
        healthText.transform.Rotate(new Vector3(0,180,0));
    }
    private void OnTriggerEnter(Collider other){
        takeDamage(other);
        other.GetComponentInParent<Bullet>().from.hit();
    }
}
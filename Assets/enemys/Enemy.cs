using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public GameObject material;
    public Color firstColor;
    public GameObject healthText;
    int time = 0;

    public void takeDamage(Collider other){
        if(health <= 0)
            Destroy(gameObject);
        health -= other.GetComponentInParent<Bullet>().damage;
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
    public void FixedUpdate(){
        if(time > 5){
            foreach(MeshRenderer g in GetComponentsInChildren<MeshRenderer>())
            {
                g.material.color = firstColor;
            }
        }
        time++;
        healthText.GetComponent<TMPro.TextMeshPro>().text = health.ToString();
        GameObject player =GameObject.FindGameObjectsWithTag("Player")[0]; 
        Debug.Log(player);
        healthText.transform.LookAt(player.transform.position); 
        healthText.transform.Rotate(new Vector3(0,180,0));
    }
    private void OnTriggerEnter(Collider other){
        takeDamage(other);
        other.GetComponentInParent<Bullet>().from.hit();
    }
}
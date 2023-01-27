using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

	private Vector3 direction;
	public float speed = 0.01f;
	public int maxTime = 0;  	
	private int time = 0;
	// Update is called once per frame
    	void Update()
    	{
		transform.Translate(transform.forward*speed);
		transform.LookAt(direction);
        	if(time >= maxTime){
			direction = new Vector3(Random.Range(0,360), 0, Random.Range(0,360));
			Debug.Log(direction);
			//direction = direction*speed;
			time = 0;	
		}
		time++;

    	}
}

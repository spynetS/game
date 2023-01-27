using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    	public float points = 0;
        public Gun gun;
	public Text pointsText;
	
	// Update is called once per frame
    	void Update()
    	{
        	pointsText.text = "Points:"+points; 
        	if (Input.GetMouseButton(0)){
            		gun.Shoot();
        	}
    }
}

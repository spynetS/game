using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
	// change select weapon on click
	// dont charge player again if they have gun
	// time
	// gun 3
	
    public float points = 0;
    public Gun gun;
	
	public TMP_Text pointsText;
		
	void Start(){

	}

// Update is called once per frame
	void Update()
	{
		pointsText.text = "Points:"+points; 
	
    }
}

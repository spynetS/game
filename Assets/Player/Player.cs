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
	
    public int points = 0;
    public Gun gun;
	
	public TMP_Text pointsText;
	public GameObject hitmark;
	Animator animator;
	
	void Start(){
		animator = hitmark.GetComponent<Animator>();
		points = PlayerData.points;

	}

	public void hitMark(int amount){
		TMP_Text text = hitmark.GetComponent<TMP_Text>();
		text.text = ""+amount;
		if(amount > 10){
		}
		animator.SetBool("on", true);


	}

// Update is called once per frame
	void Update()
	{
		pointsText.text = "Points:"+points;
		PlayerData.points = points;
	
    }
	void FixedUpdate(){

		animator.SetBool("on", false);
	}
}

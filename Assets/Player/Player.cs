using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	// we will have a gameobject with the shape of a gun with a gun script witch will be responseble
	// for the shooting mecanincs for each gun
	// then we have a ui button with the gun as a child then when the player
	// shooses a gun the players selected gun will be gatherd from the button press (child)
	
    public float points = 0;
    public Gun gun;
	public List<Button> boughtGuns = new List<Button>();
	
	public Text pointsText;
		
		void Start(){
			foreach(Button b in boughtGuns){
				
			}
		}
	
	// Update is called once per frame
    	void Update()
    	{
        	pointsText.text = "Points:"+points; 
        	if (Input.GetMouseButton(0)){
            		gun.Shoot();
        	}
    }
}

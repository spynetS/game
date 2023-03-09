using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class MenuGuns : MonoBehaviour
{
	public TMP_Text pointsText;
	public TMP_Text title;
	public TMP_Text info;
	
	public Gun gun1;
	public Gun gun2;
	public Gun gun3;
	
	public void Start(){
		Cursor.lockState = CursorLockMode.None;
	}
	
	public void addGun(int gun){
		if(!PlayerData.guns.Contains(gun.ToString())){
			if(PlayerData.points-gun>0){
				PlayerData.guns+=gun.ToString();
				PlayerData.points = PlayerData.points-gun;
			}
			selectedGun(gun);
		}
	}
	private Gun getGun(int gun){
		
		if(gun == 6000) return gun2;
		if(gun == 12000) return gun3;
		return gun1;
	}
	public void selectedGun(int gun){
		Gun g = getGun(gun);
		PlayerData.gun = g.nameid;
		title.text = g.nameid;
		info.text = "Damage:" + g.damage +"\n Speed:"+g.speed;
	}
    // Update is called once per frame
    void Update(){
        pointsText.text = ("Your Points: "+PlayerData.points.ToString());
    }
}

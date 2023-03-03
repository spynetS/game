using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ChickenSpawner : MonoBehaviour
{
    public int        chickens;
    public GameObject chicken;
	public GameObject player;
	public GameObject gun1;
	public GameObject gun2;
	public GameObject gun3;
	public int timer = 1000;
	public TMP_Text timerText;

    // Update is called once per frame
    void Start()
    {
       for(int i = 0; i < chickens; i++){
        int x = Random.Range(-20, 20);
        int y = Random.Range(-15, 25);
        Instantiate(chicken, new Vector3(x, 1, y), Quaternion.identity);
       }
	   Debug.Log(PlayerData.gun);
	   
	   if(PlayerData.gun == "Deagle"){
		   Instantiate(gun1, player.transform);
	   }
	   if(PlayerData.gun == "Shotgun"){
		   Instantiate(gun2, player.transform);
	   }
	   if(PlayerData.gun == "Ak"){
		   Instantiate(gun3, player.transform);
	   }
    }
	
	public void Update(){
		
		timerText.text = timer.ToString();
		Debug.Log(timer);
		if(timer <=0){
			SceneManager.LoadScene(2);
		}
		timer --;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{	
	public void Start(){
		Cursor.lockState = CursorLockMode.None;
	}
    // Start is called before the first frame update
	public void StartButton(){
		
		SceneManager.LoadScene(1);

	}
	public void QuitButStart(){
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenSpawner : MonoBehaviour
{
    public int chickens;
    public GameObject chicken;
    // Update is called once per frame
    void Start()
    {
       for(int i = 0; i<chickens; i++){
        int x = Random.Range(-20, 20);
        int y = Random.Range(-15, 25);
        Instantiate(chicken, new Vector3(x, 1, y), Quaternion.identity);
       }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotSpeed = 100f;
    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float translationx = Input.GetAxis("Horizontal") * speed;
        /* float rotation = Input.GetAxis("Horizontal") * rotSpeed; */

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        translationx *= Time.deltaTime;
        /* rotation *= Time.deltaTime; */
        // Move translation along the object's z-axis
        transform.Translate( translationx,0 , translation);

    }
}

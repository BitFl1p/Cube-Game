using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiggle : MonoBehaviour
{
    public float speed;
    static bool goingUp = true;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= 0.4 && goingUp)
        {
            transform.position += Vector3.up * speed;

        } else if(transform.position.y >= -0.4 && !goingUp)
        {
            transform.position += Vector3.down * speed;
        }
        if(transform.position.y > 0.4)
        {
            goingUp = false;
        } else if(transform.position.y < -0.4)
        {
            goingUp = true;
        }
    }
}

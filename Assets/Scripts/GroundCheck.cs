using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public GameObject player;
    
    void Update() { transform.position = player.transform.position; }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground") { player.GetComponent<PlayerController>().isGrounded = true;  }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Ground") { player.GetComponent<PlayerController>().isGrounded = false; }
    }
}

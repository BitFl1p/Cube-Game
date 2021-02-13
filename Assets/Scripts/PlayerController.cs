using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    static Rigidbody2D rb;
    public float speed, jumpPow;
    [HideInInspector] public bool isGrounded;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {
        if(!(transform.rotation.eulerAngles.z >= 45 && transform.rotation.eulerAngles.z <= 135 || transform.rotation.eulerAngles.z >= 225 && transform.rotation.eulerAngles.z <= 315))
        {
            GetComponent<SpriteRenderer>().size = new Vector2(Mathf.Clamp(1 + Mathf.Abs(rb.velocity.x) * 0.05f, 1f, 2f), Mathf.Clamp(1 + Mathf.Abs(rb.velocity.y) * 0.05f, 1f, 2f));
        }
        else
        {
            GetComponent<SpriteRenderer>().size = new Vector2(Mathf.Clamp(1 + Mathf.Abs(rb.velocity.y) * 0.05f, 1f, 2f), Mathf.Clamp(1 + Mathf.Abs(rb.velocity.x) * 0.05f, 1f, 2f));
        }
        rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x + (Input.GetAxisRaw("Horizontal")* speed),-5,5), rb.velocity.y);
        if(isGrounded && Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPow);
        }
        Camera.main.backgroundColor = new Color(0, Mathf.Clamp(transform.position.y * 0.001f, 0f, 0.3f), 0.3f);
    }
}

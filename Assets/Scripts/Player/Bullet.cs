using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector2 bulletSpeed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        bulletSpeed = new Vector2(3f, 0f);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(rb.position + bulletSpeed * Time.fixedDeltaTime);
    }
    void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.tag == "Zombie")
        {
            Destroy(gameObject);
        }
    }
}

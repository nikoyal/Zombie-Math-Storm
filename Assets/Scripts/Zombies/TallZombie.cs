using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TallZombie : MonoBehaviour
{
    private Vector2 speed;
    Animator animator;
    private bool spawned = false;
    private Rigidbody2D rb;
    private int health = 100;
    int damage = 40;

    // Start is called before the first frame update
    void Start()
    {
        speed = new Vector2(-0.15f, 0f);
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        if (spawned == true && health > 0)
        {
            //transform.Translate(-Vector2.right * speed * Time.deltaTime); Doesnt detect 2D Collision
            rb.MovePosition(rb.position + speed * Time.fixedDeltaTime);
        }
        if(health <= 0)
        {
            animator.SetBool("Die", true);
            StartCoroutine(Die());
        }
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            animator.SetBool("Attack", true);
            Player.health -= damage;
        }
        if(collider.gameObject.tag == "Bullet")
        {
            health -= Player.damage;
        }

    }

    void OnMouseDown()
    {
        health -= 50;
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(1f);
        Data.ZombieCount -= 0.1f;
        Destroy(gameObject);
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(0.7f);
        animator.SetBool("Spawned", true);
        spawned = true;
    }
}

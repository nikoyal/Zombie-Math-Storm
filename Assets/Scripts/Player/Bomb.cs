using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    Vector3 rotation;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rotation += Vector3.forward * 200 * Time.deltaTime;
        transform.rotation = Quaternion.Euler(rotation);

    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Zombie");
        foreach (GameObject enemy in enemies)
            GameObject.Destroy(enemy);
        Destroy(gameObject);
    }
}

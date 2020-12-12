using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    AudioSource Audio;
    public Transform bulletSpawnPoint;
    public GameObject bullet;
    Animator animator;
    public bool shoot = false;
    public static int health;
    public static int damage = 100;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        animator = GetComponent<Animator>();
        Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if(health < 0)
        {
            Destroy(gameObject);
            Data.isQuestionGenerated = false;
        }
        if (shoot == false)
        {
            animator.SetBool("Shoot", false);
        }
    }

    void OnMouseDown()
    {
         StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(0.75f);
        if(Data.CorrectAnswers < 2)
        {
            animator.SetBool("Shoot", true);
            Audio.Play(0);
            shoot = false;
            var spawnedbullet = Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        }
        Data.CorrectAnswers += 1;
    }
}

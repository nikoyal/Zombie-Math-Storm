using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExplodeAnimation : MonoBehaviour
{
    AudioSource Audio;
    Animator animator;

    void Start()
    {
        Audio = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        Debug.Log("collided");
        animator.SetBool("Explode", true);
        Audio.Play(0);
        StartCoroutine(StopAnimation());
    }
    IEnumerator StopAnimation()
    {
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("Explode", false);
    }
}

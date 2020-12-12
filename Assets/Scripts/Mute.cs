using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    AudioListener AudioListener;
    GameObject Camera;
    SpriteRenderer MuteRenderer;
    public Sprite[] MuteUnmute;
    bool muted = false;
    void Awake()
    {
        MuteRenderer = GetComponent<SpriteRenderer>();
        Camera = GameObject.Find("Main Camera");
        AudioListener = Camera.GetComponent<AudioListener>();
    }
    void OnMouseDown()
    {
        if (muted == false)
        {
            AudioListener.volume = 0f;
            MuteRenderer.sprite = MuteUnmute[0];
            muted = true;
        }
        else
        {
            AudioListener.volume = 1f;
            MuteRenderer.sprite = MuteUnmute[1];
            muted = false;
        }
    }
}

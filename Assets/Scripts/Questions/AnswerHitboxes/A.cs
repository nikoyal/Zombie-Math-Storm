using UnityEngine.UI;
using UnityEngine;
using System;

public class A : MonoBehaviour
{
    Text txt;
    void OnMouseDown()
    {
        Player p = GameObject.Find("Player").GetComponent<Player>();
        txt = GameObject.Find("A").GetComponent<Text>();
        string cutString = txt.text.ToString().Remove(0, 3);
        if (Math.result == int.Parse(cutString))
        {
            p.StartCoroutine("Shoot");
        }
        Data.isQuestionGenerated = false;
        Math.reloading = true;
        UIScripit.reloadingInstasiated = false;
    }
}

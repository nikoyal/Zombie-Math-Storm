using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBomb : MonoBehaviour
{
    public GameObject Bomb;
    void Update()
    {
        if(Data.CorrectAnswers == 3)
        {
            Instantiate(Bomb, gameObject.transform.position, Quaternion.identity);
            Data.CorrectAnswers = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Reloading : MonoBehaviour
{
    // Start is called before the first frame update

    public static float reloadCooldown = 0;
    void Update()
    {
        if (Data.isQuestionGenerated == false && Math.reloading == true)
        {
            if (reloadCooldown < 3)
            {
                reloadCooldown += Time.deltaTime;
            }
            if (reloadCooldown >= 3)
            {
                Math.reloading = false;
                Data.isQuestionGenerated = false;
                reloadCooldown = 0;
            }
        };
    }
}

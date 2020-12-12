using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScripit : MonoBehaviour
{
    public GameObject reloadingUI;
    public static bool reloadingInstasiated = false;
    void Update()
    {
        if (reloadingInstasiated == false && Data.isQuestionGenerated == false && Math.reloading == true)
        {
            //Vector3 instansiateReloadPosition = new Vector3(454, 553, -3);
            //var reloading = Instantiate(reloadingUI, instansiateReloadPosition, Quaternion.identity);
            //reloading.transform.parent = gameObject.transform;
            reloadingInstasiated = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[ExecuteInEditMode]
public class ProgressBar : MonoBehaviour
{
    public int maximum;
    public Image mask;

    void Update()
    {
        GetCurrentFill();
    }

    void GetCurrentFill()
    {
        float fillAmount = Reloading.reloadCooldown / (float)maximum;
        mask.fillAmount = fillAmount;
    }
}

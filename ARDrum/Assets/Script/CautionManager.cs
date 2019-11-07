using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CautionManager : MonoBehaviour
{
    public GameObject CautionPannel;

    public void ActivateCaution()
    {
        CautionPannel.SetActive(true);
        Invoke("setFalse", 1f);
    }

    void setFalse()
    {
        CautionPannel.SetActive(false);
    }
}

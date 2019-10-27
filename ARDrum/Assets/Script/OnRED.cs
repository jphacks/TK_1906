using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnRED : MonoBehaviour
{
    public GameObject REDPannel;

    public void ActivateCaution()
    {
        REDPannel.SetActive(true);
        Invoke("setFalse", 1f);
    }

    void setFalse()
    {
        REDPannel.SetActive(false);
    }
}

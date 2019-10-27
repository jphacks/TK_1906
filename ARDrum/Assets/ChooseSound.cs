using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseSound : MonoBehaviour
{
    string soundString;

    public void ChoseSound()
    {
        switch (GetComponent<Dropdown>().value)
        {
            case 0:
                soundString = "Bass";
                break;
            case 1:
                soundString = "Cymbal";
                break;
            case 2:
                soundString = "Hat";
                break;
            case 3:
                soundString = "Snare";
                break;
            default:
                soundString = "NULL";
                break;
        }
    }

    public string GetCurrentSound()
    {
        return soundString;
    }

}

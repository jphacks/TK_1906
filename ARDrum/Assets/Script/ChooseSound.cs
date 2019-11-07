using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseSound : MonoBehaviour
{
    string soundString = "Bass";
    AudioManager audioManager;

    private void Start()
    {
        audioManager = GameObject.Find("UserDefinedTargetBuilder").GetComponent<AudioManager>();
    }

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
            case 4:
                soundString = "Do";
                break;
            case 5:
                soundString = "Re";
                break;
            case 6:
                soundString = "Mi";
                break;
            case 7:
                soundString = "Fa";
                break;
            case 8:
                soundString = "So";
                break;
            case 9:
                soundString = "Ra";
                break;
            case 10:
                soundString = "Si";
                break;
            case 11:
                soundString = "Do2";
                break;
            default:
                soundString = "NULL";
                break;
        }
        audioManager.playSound(soundString);
    }

    public string GetCurrentSound()
    {
        return soundString;
    }

}

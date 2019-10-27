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
                audioManager.playBass();
                break;
            case 1:
                soundString = "Cymbal";
                audioManager.playCymbal();
                break;
            case 2:
                soundString = "Hat";
                audioManager.playHat();
                break;
            case 3:
                soundString = "Snare";
                audioManager.playSnare();
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

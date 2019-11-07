using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    /// ドラム
    public AudioClip Bass;
    public AudioClip Cymbal;
    public AudioClip Hat;
	public AudioClip Snare;
    ///　ピアノ
    public AudioClip Do;
    public AudioClip Re;
    public AudioClip Mi;
    public AudioClip Fa;
    public AudioClip So;
    public AudioClip Ra;
    public AudioClip Si;
    public AudioClip Do2;
    AudioSource audioSource;

    void Start()
    {
		audioSource = GetComponent<AudioSource>();
    }



    public void playSound(string sound)
    {
        switch (sound)
        {
            /// ドラム
            case "Bass":
                audioSource.PlayOneShot(Bass);
                break;
            case "Cymbal":
                audioSource.PlayOneShot(Cymbal);
                break;
            case "Hat":
                audioSource.volume = 1.0f;
                audioSource.PlayOneShot(Hat);
                audioSource.volume = 0.7f;
                break;
            case "Snare":
                audioSource.PlayOneShot(Snare);
                break;
            /// ピアノ
            case "Do":
                audioSource.PlayOneShot(Do);
                break;
            case "Re":
                audioSource.PlayOneShot(Re);
                break;
            case "Mi":
                audioSource.PlayOneShot(Mi);
                break;
            case "Fa":
                audioSource.PlayOneShot(Fa);
                break;
            case "So":
                audioSource.PlayOneShot(So);
                break;
            case "Ra":
                audioSource.PlayOneShot(Ra);
                break;
            case "Si":
                audioSource.PlayOneShot(Si);
                break;
            case "Do2":
                audioSource.PlayOneShot(Do2);
                break;

        }
    }
}

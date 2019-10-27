using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip Bass;
    public AudioClip Cymbal;
    public AudioClip Hat;
	public AudioClip Snare;
    AudioSource audioSource;

    void Start()
    {
		audioSource = GetComponent<AudioSource>();
    }



    public void playSound(string sound)
    {
        switch (sound)
        {
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
        }
    }

    public void playBass()
	{
        audioSource.PlayOneShot(Bass);
	}

	public void playCymbal()
	{
        audioSource.PlayOneShot(Cymbal);
	}

    public void playHat()
	{
       audioSource.PlayOneShot(Hat);
	}

    public void playSnare()
	{
        audioSource.PlayOneShot(Snare);
	}
}

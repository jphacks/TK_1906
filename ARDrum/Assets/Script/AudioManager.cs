using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip Bass;
    public AudioClip Cymbal;
    public AudioClip Hat;
	public AudioClip Snare;
	public AudioSource audioSource;


    void Start()
    {
		audioSource = GetComponent<AudioSource>();
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageChecker : MonoBehaviour
{
    MeshRenderer meshRenderer;
    AudioSource audioSource;

    bool pastStatus;

    private void Start()
    {
        pastStatus = false;
        audioSource = this.gameObject.GetComponent<AudioSource>();
        meshRenderer = this.gameObject.GetComponent<MeshRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        CheckImage();
    }

    void CheckImage()
    {
        if (meshRenderer.enabled == false && pastStatus != meshRenderer.enabled)
        {
            Debug.Log("Disappeared!!");
            audioSource.PlayOneShot(audioSource.clip);
        }
        pastStatus = meshRenderer.enabled;
    }
}

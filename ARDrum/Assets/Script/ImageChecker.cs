using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageChecker : MonoBehaviour
{
    MeshRenderer meshRenderer;
    bool changed;
    bool isFirst;
    private void Start()
    {
        isFirst = true;
        changed = false;
        meshRenderer = this.gameObject.GetComponent<MeshRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        CheckImage();
    }

    void CheckImage()
    {
        if (meshRenderer.enabled == false && changed != meshRenderer.enabled)
        {
            Debug.Log("Disappeared!!");
        }
        changed = meshRenderer.enabled;
    }
}

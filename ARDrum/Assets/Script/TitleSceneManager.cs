using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour
{
    [SerializeField] float fadeSpeed;
    Image FadePanelImage;
    float alpha;
    float startTime;
    bool setTime;
    // Start is called before the first frame update
    void Start()
    {
        setTime = false;
        FadePanelImage = GetComponent<Image>();
        FadePanelImage.enabled = true;
        FadePanelImage.color = new Color(255f, 255f, 255f, 1.0f);
        alpha = FadePanelImage.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        FadePanel();
        if ((alpha <= 0.0f) && !setTime)
        {
            startTime = Time.time;
            setTime = true;
        }
        if ((Time.time - startTime > 2f) && setTime)
        {
            SceneManager.LoadScene("UserDefined");
        }
    }

    void FadePanel()
    {
        alpha -= fadeSpeed;
        FadePanelImage.color = new Color(255f, 255f, 255f, alpha);
    }
}

/*===============================================================================
Copyright(c) 2017 PTC Inc.All Rights Reserved.


Vuforia is a trademark of PTC Inc., registered in the United States and other
countries.
===============================================================================*/
using UnityEngine;
using UnityEngine.UI;

public class FrameQualityMeter : MonoBehaviour
{
    public GameObject BADPannel;
    public GameObject NORMALPannel;
    public GameObject GOODPannel;

    public void SetQuality(Vuforia.ImageTargetBuilder.FrameQuality quality)
    {
        switch (quality)
        {
            case (Vuforia.ImageTargetBuilder.FrameQuality.FRAME_QUALITY_NONE):
                BADPannel.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.5f);
                NORMALPannel.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.5f);
                GOODPannel.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.5f);
                break;
            case (Vuforia.ImageTargetBuilder.FrameQuality.FRAME_QUALITY_LOW):
                BADPannel.GetComponent<Image>().color = new Color(1f, 0f, 0f, 1f);
                NORMALPannel.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.5f);
                GOODPannel.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.5f);
                break;
            case (Vuforia.ImageTargetBuilder.FrameQuality.FRAME_QUALITY_MEDIUM):
                BADPannel.GetComponent<Image>().color = new Color(1f, 0f, 0f, 1f);
                NORMALPannel.GetComponent<Image>().color = new Color(1f, 1f, 0f, 1f);
                GOODPannel.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.5f);
                break;
            case (Vuforia.ImageTargetBuilder.FrameQuality.FRAME_QUALITY_HIGH):
                BADPannel.GetComponent<Image>().color = new Color(1f, 0f, 0f, 1f);
                NORMALPannel.GetComponent<Image>().color = new Color(1f, 1f, 0f, 1f);
                GOODPannel.GetComponent<Image>().color = new Color(0f, 1f, 0f, 1f);
                break;
        }
    }
}

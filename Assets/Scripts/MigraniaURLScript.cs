using UnityEngine;

public class MigraniaURLScript : MonoBehaviour
{
    [SerializeField] private Animator logoStarAnimation;
    [SerializeField] private GameObject BackGroundDistortionGB;
    private bool isSpinning = false;
    private bool isShowBackGroundDistortion = false;

    public void GoToURL(string url)
    {
        Application.OpenURL(url);
    }

    public void StarLogoAnimation()
    {
        isSpinning = !isSpinning;
        logoStarAnimation.SetBool("IsSpinning", isSpinning);
    }

    public void BackGroundSwitch()
    {
        isShowBackGroundDistortion = !isShowBackGroundDistortion;
        if (isShowBackGroundDistortion)
        {
            BackGroundDistortionGB.SetActive(true);
        }
        else
        {
            BackGroundDistortionGB.SetActive(false);
        }
        
    }
}

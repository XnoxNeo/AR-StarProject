using UnityEngine;

public class StarScript : MonoBehaviour
{
    [SerializeField] GameObject backGroundDistortion;
    private bool isBackGroundOn;

    public void Awake()
    {
        gameObject.SetActive(false);
    }

    public void OnTargetLost()
    {
        gameObject.SetActive(false);
        backGroundDistortionSwitch();
    }

    public void backGroundDistortionSwitch()
    {
        isBackGroundOn = !isBackGroundOn;
        if (isBackGroundOn) 
        {
            backGroundDistortion.SetActive(false);
        }

    }

}

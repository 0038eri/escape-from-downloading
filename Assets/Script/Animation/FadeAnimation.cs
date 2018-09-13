using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeAnimation : SingletonMonoBehaviour<FadeAnimation> {

    private Image fadePanel;
    private float alpha;
    float red, green, blue;
    private float fadeSpeed = 0.01f;
    private bool isFadeIn = false;
    private bool isFadeOut = false;

    private void Start()
    {
        DontDestroyOnLoad(this);
        fadePanel = GameObject.Find("Panel").GetComponent<Image>();
        red = fadePanel.color.r;
        green = fadePanel.color.g;
        blue = fadePanel.color.b;
        alpha = fadePanel.color.a;
    }

    private void Update()
    {
        if(isFadeIn == true)
        {
            fadeIn();
        }
        else if(isFadeOut == true)
        {
            fadeOut();
        }

    }

    // 明転
    public void fadeIn()
    {
        fadePanel.color = new Color(red, green, blue, alpha);
        alpha -= fadeSpeed;
    }

    // 暗転
    public void fadeOut()
    {
        fadePanel.color = new Color(red, green, blue, alpha);
        alpha += fadeSpeed;
    }

    public void goFadeIn()
    {
        isFadeOut = false;
        isFadeIn = true;
    }

    public void goFadeOut()
    {
        isFadeIn = false;
        isFadeOut = true;
    }

}
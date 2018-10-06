using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeAnimation : SingletonMonoBehaviour<FadeAnimation> {

    private Image fadePanel;
    public float alpha;
    float red, green, blue;
    private float fadeSpeed = 0.03f;
    private bool isFadeIn = false;
    private bool isFadeOut = false;

    public float fadeTime_parent;

    public string nextSceneName;

    private void Start()
    {
        DontDestroyOnLoad(this);
        fadePanel = GameObject.Find("Panel").GetComponent<Image>();
        red = fadePanel.color.r;
        green = fadePanel.color.g;
        blue = fadePanel.color.b;
        alpha = fadePanel.color.a;
    }

    public float valueFadeTime()
    {
        return fadeTime_parent;
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
        if(alpha > 0.0f)
        {
            fadePanel.color = new Color(red, green, blue, alpha);
            alpha -= fadeSpeed;
        }
        else if(alpha <= 0.0f)
        {
            isFadeIn = false;
        }
    }

    // 暗転
    public void fadeOut()
    {
        if(alpha < 1.0f)
        {
            fadePanel.color = new Color(red, green, blue, alpha);
            alpha += fadeSpeed;
        }
        else if(alpha >= 1.0f)
        {
            isFadeOut  = false;

        }
        
    }
    
    private void sceneTransition()
    {
        SceneManager.LoadScene(nextSceneName);
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScn : MonoBehaviour {

    private int stageJudgeNumber;

    public Button[] stageButton;
    private float fadeTime = 2.0f;

    void Start()
    {
        FadeAnimation.Instance.goFadeIn();
        StartCoroutine(StartMethodM());
        stageJudgeNumber = StageJudgeManager.Instance.stageNumberCheck();
    }

    IEnumerator StartMethodM()
    {
        yield return new WaitForSeconds(fadeTime);
        SoundManager.Instance.playBgm();
        CanPlay();
    }

    void CanPlay()
    {
        for(int i = 0; i < stageJudgeNumber; i++)
        {
            stageButton[i].interactable = true;
        }

    }

    // スタート画面に移動
    public void toStart ()
    {
        FadeAnimation.Instance.goFadeOut();
        StartCoroutine(scnStartCoroutine());
    }

    IEnumerator scnStartCoroutine()
    {
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene("Start");
    }

    // オプション画面に移動
    public void toOption ()
    {
        SceneManager.LoadScene("Option");
    }

	// ステージ1に移動
	public void toStage1 () 
    {
        FadeAnimation.Instance.goFadeOut();
        StartCoroutine(oneCoroutine());
	}

    IEnumerator oneCoroutine()
    {
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene ("Stage1");
    }

    // ステージ2に移動
    public void toStage2 ()
    {
        FadeAnimation.Instance.goFadeOut();
        StartCoroutine(twoCoroutine());
    }

    IEnumerator twoCoroutine()
    {
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene ("Stage2");
    }

    // ステージ3に移動
    public void toStage3 ()
    {
        FadeAnimation.Instance.goFadeOut();
        StartCoroutine(threeCoroutine());
    }

    IEnumerator threeCoroutine()
    {
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene ("Stage3");
    }

    // ステージ4に移動
    public void toStage4 ()
    {
        FadeAnimation.Instance.goFadeOut();
        StartCoroutine(fourCoroutine());
    }

    IEnumerator fourCoroutine()
    {
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene ("Stage4");
    }

    // ステージ5に移動
    public void toStage5 ()
    {
        FadeAnimation.Instance.goFadeOut();
        StartCoroutine(fiveCoroutine());
    }

    IEnumerator fiveCoroutine()
    {
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene ("Stage5");
    }

    // ステージ6に移動
    public void toStage6 ()
    {
        FadeAnimation.Instance.goFadeOut();
        StartCoroutine(sixCoroutine());
    }

    IEnumerator sixCoroutine()
    {
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene ("Stage6");
    }

    // ステージ7に移動
    public void toStage7 ()
    {
        FadeAnimation.Instance.goFadeOut();
        StartCoroutine(sevenCoroutine());
    }

    IEnumerator sevenCoroutine()
    {
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene ("Stage7");
    }

    // ステージ8に移動
    public void toStage8 ()
    {
        FadeAnimation.Instance.goFadeOut();
        StartCoroutine(eightCoroutine());
    }

    IEnumerator eightCoroutine()
    {
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene ("Stage8");
    }

    // ステージ9に移動
    public void toStage9 ()
    {
        FadeAnimation.Instance.goFadeOut();
        StartCoroutine(nineCoroutine());
    }

    IEnumerator nineCoroutine()
    {
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene ("Stage9");
    }

    // ステージ10に移動
    public void toStage10 ()
    {
        FadeAnimation.Instance.goFadeOut();
        StartCoroutine(tenCoroutine());
    }

    IEnumerator tenCoroutine()
    {
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene ("Stage10");
    }

    // ステージ11に移動
    public void toStage11 ()
    {
        FadeAnimation.Instance.goFadeOut();
        StartCoroutine(elevenCoroutine());
    }

    IEnumerator elevenCoroutine()
    {
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene ("Stage11");
    }

    // ステージ12に移動
    public void toStage12 ()
    {
        FadeAnimation.Instance.goFadeOut();
        StartCoroutine(twelveCoroutine());
    }

    IEnumerator twelveCoroutine()
    {
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene ("Stage12");
    }
   
}
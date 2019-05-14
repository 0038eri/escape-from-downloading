using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingScn : MonoBehaviour
{

  private float fadeTime;

  private void Start()
  {
    GameModeManager.Instance.talkScene();
    fadeTime = FadeAnimation.Instance.valueFadeTime();
    FadeAnimation.Instance.goFadeIn();
    StartCoroutine(endingCoroutine());
  }

  IEnumerator endingCoroutine()
  {
    yield return new WaitForSeconds(fadeTime);
    SoundManager.Instance.playBgm();
  }

}
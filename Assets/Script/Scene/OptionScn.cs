using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class OptionScn : SingletonMonoBehaviour<OptionScn>
{

  public string usernameOp;

  // 0:オフ 1:オン
  private int soundSaveInt;
  public Sprite[] soundSprites;
  public Image[] soundImages;

  // 入力フィールド
  public InputField inputfield;

  private void Start()
  {
    soundSaveInt = SoundManager.Instance.soundState();
    SoundManager.Instance.playSound();
    soundSprite();
  }

  // メニューに戻る
  public void backMenu()
  {
    SceneManager.LoadScene("Menu");
  }

  void soundSprite()
  {
    // BGMがオン
    if (soundSaveInt == 1)
    {
      soundImages[0].sprite = soundSprites[1];
    }
    // BGMがオフ
    else if (soundSaveInt == 0)
    {
      soundImages[0].sprite = soundSprites[0];
    }
  }

  public void switchSound()
  {
    // BGMをオフにする
    if (soundSaveInt == 1)
    {
      soundSaveInt = 0;
      soundImages[0].sprite = soundSprites[0];
    }
    // BGMをオンにする
    else if (soundSaveInt == 0)
    {
      soundSaveInt = 1;
      soundImages[0].sprite = soundSprites[1];
    }
    SoundManager.Instance.changeSound(soundSaveInt);
  }

  public int resultSound()
  {
    return soundSaveInt;
  }

  // ユーザーネーム変更
  public void changeUsername()
  {
    usernameOp = inputfield.text;
    UserManager.Instance.updateUsername();
  }

  public string sendName()
  {
    return usernameOp;
  }

}
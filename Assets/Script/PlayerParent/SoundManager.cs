using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : SingletonMonoBehaviour<SoundManager>
{

  // 0:オフ 1:オン
  private static int soundSwitch = 1;

  public AudioSource[] audioSources;
  public AudioClip[] systemBgmClips;
  public AudioClip[] stageBgmClips;
  public AudioClip[] seClips;

  private void Start()
  {
    audioSources = GetComponents<AudioSource>();
    // soundSwitch = PlayerPrefs.GetInt("bgmSave");
  }

  public void changeSound(int soundSwitch)
  {
    // PlayerPrefs.SetInt("bgmSave", soundSwitch);
  }

  public void playSound()
  {
    if (soundSwitch == 1)
    {
      string nowScene = SceneManager.GetActiveScene().name;
      switch (nowScene)
      {
        case "Start":
          audioSources[0].clip = systemBgmClips[0];
          audioSources[0].Play();
          break;
        case "Menu":
          audioSources[0].clip = systemBgmClips[2];
          audioSources[0].Play();
          break;
        case "Option":
          audioSources[0].clip = systemBgmClips[3];
          audioSources[0].Play();
          break;
        default:
          audioSources[0].Stop();
          break;
      }
    }
    else if (soundSwitch == 0)
    {
      audioSources[0].Stop();
    }
  }

  public int soundState()
  {
    return soundSwitch;
  }

}
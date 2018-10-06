using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : SingletonMonoBehaviour<SoundManager>
{

    // 0:オフ 1:オン
    private static int bgmSwitch = 1;
    private static int seSwitch = 1;

    public AudioSource[] audioSources;
    public AudioClip[] systemBgmClips;
    public AudioClip[] stageBgmClips;
    public AudioClip[] seClips;

    private void Start()
    {
        audioSources = GetComponents<AudioSource>();
        bgmSwitch = PlayerPrefs.GetInt("bgmSave");
        seSwitch = PlayerPrefs.GetInt("seSave");
    }

    public void changeBgm(int bgmSwitch)
    {
        PlayerPrefs.SetInt("bgmSave", bgmSwitch);
    }

    public void changeSe()
    {
        seSwitch = OptionScn.Instance.resultSe();
        PlayerPrefs.SetInt("seSave", seSwitch);
    }

    public void playBgm()
    {
        if (bgmSwitch == 1)
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
        } else if (bgmSwitch==0)
        {
            audioSources[0].Stop();
        }
    }

    public void playSe()
    {
        
    }

    public int bgmState()
    {
        return bgmSwitch;
    }

    public int seState()
    {
        return seSwitch;
    }

}
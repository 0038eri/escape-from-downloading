using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class OptionScn : SingletonMonoBehaviour<OptionScn> {

    public string usernameOp;

    // 0:オフ 1:オン
    private int bgmSaveInt;
    private int seSaveInt;
    public Sprite[] soundSprites;
    public Image[] soundImages;
    
    // 入力フィールド
	public InputField inputfield;

    private void Start()
    {
        bgmSaveInt = SoundManager.Instance.bgmState();
        seSaveInt = SoundManager.Instance.seState();
        SoundManager.Instance.playBgm();
        bgmSprite();
        seSprite();
    }

    // メニューに戻る
    public void backMenu () {
        SceneManager.LoadScene("Menu");
    }

    void bgmSprite()
    {
        // BGMがオン
        if (bgmSaveInt == 1)
        {
            soundImages[0].sprite = soundSprites[1];
        }
        // BGMがオフ
        else if (bgmSaveInt == 0)
        {
            soundImages[0].sprite = soundSprites[0];
        }
    }

    void seSprite()
    {
        // SEがオン
        if (seSaveInt == 1)
        {
            soundImages[1].sprite = soundSprites[1];
        }
        // SEが
        else if (seSaveInt == 0)
        {
            soundImages[1].sprite = soundSprites[0];
        }
    }

    public void switchBgm()
    {
        // BGMをオフにする
        if (bgmSaveInt == 1)
        {
            bgmSaveInt = 0;
            soundImages[0].sprite = soundSprites[0];
        }
        // BGMをオンにする
        else if (bgmSaveInt == 0)
        {
            bgmSaveInt = 1;
            soundImages[0].sprite = soundSprites[1];
        }
        SoundManager.Instance.changeBgm(bgmSaveInt);
    }

    public void switchSe()
    {
        // SEをオフにする
        if (seSaveInt == 1)
        {
            seSaveInt = 0;
            soundImages[1].sprite = soundSprites[0];
        }
        // SEをオンにする
        else if (seSaveInt == 0)
        {
            seSaveInt = 1;
            soundImages[1].sprite = soundSprites[1];
        }
        SoundManager.Instance.changeSe();
    }

    public int resultBgm()
    {
        return bgmSaveInt;
    }

    public int resultSe()
    {
        return seSaveInt;
    }

    // ユーザーネーム変更
	public void changeUsername () 
    {
        usernameOp = inputfield.text;
        UserManager.Instance.updateUsername();
    }

    public string sendName()
    {
        return usernameOp;
    }

}
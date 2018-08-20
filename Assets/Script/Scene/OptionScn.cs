using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class OptionScn : MonoBehaviour {

    private bool bgmFlag;
    private bool seFlag;
    
    // 入力フィールド
	public InputField inputfield;

    // メニューに戻る
    public void backMenu () {
        SceneManager.LoadScene("Menu");
    }

    public void trueBgm()
    {
        bgmFlag = true;
    }

    public void falseBgm()
    {
        bgmFlag = false;
    }

    public void trueSe()
    {
        seFlag = true;
    }

    public void falseSe()
    {
        seFlag = false;
    }

    public bool switchBgm()
    {
        return bgmFlag;
    }

    public bool switchSe()
    {
        return seFlag;
    }

    // ユーザーネーム変更
	public void changeUsername () {
        //PlayerState.username = inputfield.text; // 入力されたテキストを文字列に入れる
		GameObject.Find("PlayerManager").SendMessage ("updateUsername"); // ユーザーネームを保存
	}

}
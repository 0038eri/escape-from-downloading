using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserManager : SingletonMonoBehaviour<UserManager> {

    // ユーザーネーム文字列
    public static string username;
    // ユーザーネーム表示テキスト
    public Text usernameText;
    private int selectGender;
    /// <summary>
    /// 0 : boy
    /// 1 : girl
    /// </summary>
    private bool gender;
    /// <summary>
    /// true : boy
    /// false : girl
    /// </summary>

    private void Start()
    {
        username = PlayerPrefs.GetString("usernameSave");
        //selectGender = PlayerPrefs.GetInt("genderSave");
        //decidedGender();
    }

    //public void decidedGender()
    //{
    //    if (selectGender == 0)
    //    {
    //        gender = true;
    //    }
    //    else if (selectGender == 1)
    //    {
    //        gender = false;
    //    }
    //    PlayerPrefs.SetInt("genderSave", selectGender);
    //}

    public void decidedUsername()
    {
        PlayerPrefs.SetString("usernameSave", username);
    }

    // ユーザーネーム更新
    public void updateUsername()
    {
        username = OptionScn.Instance.sendName();
        usernameText.text = username;
        PlayerPrefs.SetString("usernameSave", username);
    }

}
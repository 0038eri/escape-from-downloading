using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserManager : SingletonMonoBehaviour<UserManager> {

    // ユーザーネーム文字列
    public static string username;
    // ユーザーネーム表示テキスト
    public Text usernameText;

    private void Start()
    {
        //username = PlayerPrefs.GetString("usernameSave");
    }

    // ユーザーネーム更新
    public void updateUsername()
    {
        usernameText.text = username;
        PlayerPrefs.SetString("usernameSave", username);
    }

}
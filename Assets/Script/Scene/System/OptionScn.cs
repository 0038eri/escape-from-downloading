using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class OptionScn : MonoBehaviour {

    // ユーザーネーム文字列
	private string Username_string="name";
    // 入力フィールド
	public InputField inputfield;

    // オプションに戻る
    public void backMenu () {
        SceneManager.LoadScene("Menu");
    }

    // ユーザーネーム変更
	public void changeUsername () {
        //入力されたテキストを文字列に入れる
		Username_string = inputfield.text;      
        // 対応していなかったら
		if (!Regex.IsMatch(Username_string, @"[^a-zA-z0-9-_]")) {
			inputfield.text = "User Name"; //「User Name」を入れる
		}
		//PlayerState.username = Username_string; // PlayerStateにユーザーネームを入れる
		GameObject.Find("Player").SendMessage ("updateUsername"); // ユーザーネームを保存
	}

}
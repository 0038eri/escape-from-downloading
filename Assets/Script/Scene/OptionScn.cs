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

    // メニューに戻る
    public void backMenu () {
        SceneManager.LoadScene("Menu");
    }

    // ユーザーネーム変更
	public void changeUsername () {
        Username_string = inputfield.text; //入力されたテキストを文字列に入れる
		GameObject.Find("PlayerManager").SendMessage ("updateUsername"); // ユーザーネームを保存
	}

}
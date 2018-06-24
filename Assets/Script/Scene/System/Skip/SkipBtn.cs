using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipBtn : MonoBehaviour {
	
    // ボタン
    public GameObject skipBt;

	void Start () {

        /// ボタンを非表示にする
		/// コルーチンを呼び出し
		skipBt.SetActive (false);
		StartCoroutine (Btn ());

	}

    /// 0.5秒経過したら
	/// ボタンを表示させる
	IEnumerator Btn () {
		yield return new WaitForSeconds(0.5f);      
		skipBt.SetActive (true);
	}

}
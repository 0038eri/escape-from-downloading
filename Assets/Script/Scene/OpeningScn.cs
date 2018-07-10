using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpeningScn : MonoBehaviour {

    // 文章表示テキスト
    public Text[] sentencesText;

    // 文章格納変数
    public string[] sentence1={"こんにちは","これはテストです","スキップしてください"};

    // 文章判定変数
    private int sentence1Check = 0;

    private void Update()
    {
     
        //// クリックした時
        //if(Input.GetMouseButtonDown(0)){
        //    typeText(); // 会話を進める
        //}

    }

    // テキストをタイプする
    public void typeText () {
        sentencesText[1].text = sentence1[0].ToString();
        sentence1Check++;
    }

}